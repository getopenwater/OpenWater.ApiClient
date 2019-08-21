using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenWater.ApiClient.Utils;

namespace OpenWater.ApiClient
{
    public class OpenWaterHttpClient
    {
        private readonly SemaphoreSlim _maxRequestsSemaphoreSlim;
        private readonly HttpClient _httpClient;
        private readonly List<DateTimeOffset> _dateTimeList = new List<DateTimeOffset>();
        private readonly bool _isHttpClientInjected;

        public static int RequestsPerSecond { get; set; } = 20;
        public static int SimultaneousRequests { get; set; } = 2;

        internal OpenWaterHttpClient(HttpClient httpClient)
        {
            if (httpClient == null)
            {
                _httpClient = new HttpClient();
            }
            else
            {
                _isHttpClientInjected = true;
                _httpClient = httpClient;
            }

            _maxRequestsSemaphoreSlim = new SemaphoreSlim(SimultaneousRequests, SimultaneousRequests);
        }

        internal void Dispose()
        {
            _maxRequestsSemaphoreSlim?.Dispose();

            if(!_isHttpClientInjected)
                _httpClient?.Dispose();
        }

        internal async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption option, CancellationToken token)
        {
            await _maxRequestsSemaphoreSlim.WaitAsync(token);

            try
            {
                _dateTimeList.Throttle(RequestsPerSecond, DateTimeOffset.UtcNow);
                var dateTimeOffsetStarted = _dateTimeList.AddUtcNow();

                return await _httpClient.SendAsync(request, token).ContinueWith(r =>
                {
                    _dateTimeList.Replace(dateTimeOffsetStarted, DateTimeOffset.UtcNow);
                    return r.Result;
                }, token);
            }
            finally
            {
                _maxRequestsSemaphoreSlim.Release();
            }
        }
    }
}
