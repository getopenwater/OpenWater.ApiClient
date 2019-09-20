using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using OpenWater.ApiClient.Extensions;

[assembly: InternalsVisibleTo("OpenWater.ApiClient.Tests")]

namespace OpenWater.ApiClient
{
    public class OpenWaterHttpClient : Disposable
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

        internal Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption option, CancellationToken token)
        {
            _maxRequestsSemaphoreSlim.Wait(token);

            try
            {
                var requestStartedAt = DateTimeOffset.UtcNow;
                _latestRequestStartOrResponseFinishTimes.Throttle(NumberOfRequestsPerSecond, requestStartedAt);

                return _httpClient.SendAsync(request, token).ContinueWith(r =>
                {
                    // Calculate throttling time by using request start or response finish time.
                    _latestRequestStartOrResponseFinishTimes.AddOrUpdateLast(requestStartedAt, DateTimeOffset.UtcNow);
                    return r.Result;
                }, token);
            }
            finally
            {
                _maxRequestsSemaphoreSlim.Release();
            }
        }

        protected override void DisposeCore()
        {
            _maxRequestsSemaphoreSlim.Dispose();

            if (!_hasExternalHttpClient)
                _httpClient.Dispose();
        }
    }
}
