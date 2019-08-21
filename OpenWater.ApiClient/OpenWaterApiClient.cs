using System;
using System.Net.Http;
using System.Text;

namespace OpenWater.ApiClient
{
    public sealed partial class OpenWaterApiClient
    {
        private readonly string _clientKey;
        private readonly string _apiKey;
        private readonly string _organizationCode;
        private readonly bool? _suppressEmails;
        
        public OpenWaterApiClient(string clientKey, string apiKey, string organizationCode = null, bool? suppressEmails = null, string baseUrl = "https://api.secure-platform.com") : this(clientKey, apiKey, organizationCode, suppressEmails, baseUrl, null)
        {
        }

        public OpenWaterApiClient(string clientKey, string apiKey, string organizationCode, bool? suppressEmails, string baseUrl, HttpClient httpClient) : this(baseUrl, new OpenWaterHttpClient(httpClient))
        {
            _clientKey = clientKey;
            _apiKey = apiKey;
            _organizationCode = organizationCode;
            _suppressEmails = suppressEmails;
        }

        partial void PrepareRequest(OpenWaterHttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
        {
            request.Headers.TryAddWithoutValidation("X-ClientKey", ConvertToString(_clientKey, System.Globalization.CultureInfo.InvariantCulture));
            request.Headers.TryAddWithoutValidation("X-ApiKey", ConvertToString(_apiKey, System.Globalization.CultureInfo.InvariantCulture));

            if (!string.IsNullOrEmpty(_organizationCode))
                request.Headers.TryAddWithoutValidation("X-OrganizationCode", ConvertToString(_organizationCode, System.Globalization.CultureInfo.InvariantCulture));

            if (_suppressEmails.HasValue)
                request.Headers.TryAddWithoutValidation("X-SuppressEmails", ConvertToString(_suppressEmails, System.Globalization.CultureInfo.InvariantCulture));
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}