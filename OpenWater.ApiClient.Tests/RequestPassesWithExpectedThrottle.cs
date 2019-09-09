using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenWater.ApiClient.Tests
{
    internal sealed class MockHttpMessageHandler : HttpMessageHandler
    {
        private readonly Task<HttpResponseMessage> _responseMessage;

        internal MockHttpMessageHandler(Task<HttpResponseMessage> responseMessage)
        {
            _responseMessage = responseMessage;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return _responseMessage;
        }
    }

    public class RequestPassesWithExpectedThrottle
    {
        internal const int MillisecondsInSecond = 1000;

        private HttpClient _httpClient;
        private OpenWaterHttpClient _openWaterHttpClient;

        [Test]
        [TestCase(1, 1, 5, 5, 0)]
        [TestCase(1, 50, 5, 5, 0)]
        [TestCase(50, 50, 5, 1, 0)]
        [TestCase(50, 50, 50, 1, 0)]
        [TestCase(50, 25, 50, 1, 0)]
        [TestCase(1, 1, 5, 5, 42)]
        [TestCase(1, 50, 5, 5, 84)]
        [TestCase(1, 50, 5, 5, 21)]
        [TestCase(50, 50, 50, 1, 99)]
        [TestCase(50, 25, 50, 1, 42)]
        public void SendAsync_RequestPassesWithExpectedAverageThrottle(int requestsPerSecondCount, int simultaneousRequestsPerSecondCount, int requestCount, int expectedAverageThrottleInSeconds, int delayInMilliseconds)
        {
            // arrange
            var mockedResponseMessage = Task.Run(() =>
            {
                Thread.Sleep(delayInMilliseconds);
                return new HttpResponseMessage(HttpStatusCode.OK);
            });

            InitializeHttpClient(mockedResponseMessage);

            OpenWaterHttpClient.NumberOfRequestsPerSecond = requestsPerSecondCount;
            OpenWaterHttpClient.NumberOfSimultaneousRequests = simultaneousRequestsPerSecondCount;

            // act
            var stopwatch = new Stopwatch();
            var runningRequests = new List<Task>();

            stopwatch.Start();

            for (var i = 0; i < requestCount; i++)
            {
                var currentRequestTask = _openWaterHttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://localhost/{i}"), HttpCompletionOption.ResponseContentRead, CancellationToken.None);
                runningRequests.Add(currentRequestTask);
            }

            Task.WhenAll(runningRequests).Wait();
            stopwatch.Stop();

            var elapsedMillisecondCount = stopwatch.ElapsedMilliseconds;

            // assert

            // -1 because we calculate time from 0, not 1
            Assert.That(elapsedMillisecondCount >= (expectedAverageThrottleInSeconds - 1) * MillisecondsInSecond);
            Assert.That(elapsedMillisecondCount <= (expectedAverageThrottleInSeconds + 1) * MillisecondsInSecond);
        }

        [TearDown]
        public void TearDown()
        {
            _openWaterHttpClient?.Dispose();
            _httpClient?.Dispose();
        }

        private void InitializeHttpClient(Task<HttpResponseMessage> responseMessage)
        {
            var mockedHttpMessageHandler = new MockHttpMessageHandler(responseMessage);

            _httpClient = new HttpClient(mockedHttpMessageHandler);
            _openWaterHttpClient = new OpenWaterHttpClient(_httpClient);
        }
    }
}
