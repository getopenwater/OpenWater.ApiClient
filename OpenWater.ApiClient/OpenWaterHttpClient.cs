using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenWater.ApiClient.Extensions;

namespace OpenWater.ApiClient
{
    internal class OpenWaterHttpClient : IDisposable
    {
        private readonly SemaphoreSlim _maxRequestsSemaphoreSlim;
        private readonly HttpClient _httpClient;
        private readonly List<DateTimeOffset> _latestRequestStartOrResponseFinishTimes = new List<DateTimeOffset>();
        private readonly bool _hasExternalHttpClient;

        public static int NumberOfRequestsPerSecond { get; set; } = 20;
        public static int NumberOfSimultaneousRequests { get; set; } = 2;

        internal OpenWaterHttpClient(HttpClient httpClient)
        {
            if (httpClient == null)
                _httpClient = new HttpClient();
            else
            {
                _hasExternalHttpClient = true;
                _httpClient = httpClient;
            }

            _maxRequestsSemaphoreSlim = new SemaphoreSlim(NumberOfSimultaneousRequests, NumberOfSimultaneousRequests);
        }

        internal async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption option, CancellationToken token)
        {
            await _maxRequestsSemaphoreSlim.WaitAsync(token);

            try
            {
                var requestStartedAt = DateTimeOffset.UtcNow;
                _latestRequestStartOrResponseFinishTimes.Throttle(NumberOfRequestsPerSecond, requestStartedAt);

                return await _httpClient.SendAsync(request, token).ContinueWith(r =>
                {
                    var response = r.Result;

                    // Calculate throttling time by using request start or response finish time.
                    _latestRequestStartOrResponseFinishTimes.ReplaceLastIfAny(requestStartedAt, DateTimeOffset.UtcNow);
                    return response;
                }, token);
            }
            finally
            {
                _maxRequestsSemaphoreSlim.Release();
            }
        }

        public void Dispose()
        {
            _maxRequestsSemaphoreSlim?.Dispose();

            if (!_hasExternalHttpClient)
                _httpClient.Dispose();
        }
    }
}
