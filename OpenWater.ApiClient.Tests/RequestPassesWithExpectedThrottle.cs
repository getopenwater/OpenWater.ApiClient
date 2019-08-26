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

        internal HttpClient HttpClient;
        internal OpenWaterHttpClient OpenWaterHttpClient;

        [TearDown]
        public void TearDown()
        {
            OpenWaterHttpClient.Dispose();
            HttpClient.Dispose();
        }

        [Test]
        [TestCase(1, 1, 5, 5)]
        [TestCase(1, 50, 5, 5)]
        [TestCase(50, 50, 5, 1)]
        [TestCase(50, 50, 50, 1)]
        [TestCase(50, 25, 50, 1)]
        public void SendAsync_NoDelay_RequestPassesWithExpectedAverageThrottle(int numberOfRequestsPerSecond, int simultaneousRequests, int requestCount, int expectedAverageThrottleInSeconds)
        {
            // arrange
            var mockedResponseMessage = Task.Run(() => new HttpResponseMessage(HttpStatusCode.OK));
            var mockedHttpMessageHandler = new MockHttpMessageHandler(mockedResponseMessage);

            HttpClient = new HttpClient(mockedHttpMessageHandler);
            OpenWaterHttpClient = new OpenWaterHttpClient(HttpClient);

            OpenWaterHttpClient.NumberOfRequestsPerSecond = numberOfRequestsPerSecond;
            OpenWaterHttpClient.NumberOfSimultaneousRequests = simultaneousRequests;

            var stopwatch = new Stopwatch();
            var runningRequests = new List<Task>();

            // act
            stopwatch.Start();

            for (var i = 0; i < requestCount; i++)
            {
                var currentRequestTask = OpenWaterHttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://localhost/{i}"), HttpCompletionOption.ResponseContentRead, CancellationToken.None);
                runningRequests.Add(currentRequestTask);
            }

            Task.WhenAll(runningRequests).Wait();
            stopwatch.Stop();

            // assert

            // -1 because we calculate time from 0, not 1
            Assert.That(stopwatch.Elapsed.TotalMilliseconds >= (expectedAverageThrottleInSeconds - 1) * MillisecondsInSecond);
            Assert.That(stopwatch.Elapsed.TotalMilliseconds <= (expectedAverageThrottleInSeconds + 1) * MillisecondsInSecond);
        }

        [TestCase(1, 1, 5, 5, 42)]
        [TestCase(1, 50, 5, 5, 84)]
        [TestCase(1, 50, 5, 5, 21)]
        [TestCase(50, 50, 50, 1, 99)]
        [TestCase(50, 25, 50, 1, 42)]
        public void SendAsync_ClientDelay_RequestPassesWithExpectedAverageThrottle(int numberOfRequestsPerSecond, int simultaneousRequestsPerSecond, int requestCount, int expectedAverageThrottleInSeconds, int clientBeforeRequestDelayInMilliseconds)
        {
            // arrange
            var mockedResponseMessage = Task.Run(() =>
            {
                Thread.Sleep(clientBeforeRequestDelayInMilliseconds);
                return new HttpResponseMessage(HttpStatusCode.OK);
            });
            var mockedHttpMessageHandler = new MockHttpMessageHandler(mockedResponseMessage);

            HttpClient = new HttpClient(mockedHttpMessageHandler);
            OpenWaterHttpClient = new OpenWaterHttpClient(HttpClient);

            OpenWaterHttpClient.NumberOfRequestsPerSecond = numberOfRequestsPerSecond;
            OpenWaterHttpClient.NumberOfSimultaneousRequests = simultaneousRequestsPerSecond;

            var stopwatch = new Stopwatch();
            var runningRequests = new List<Task>();

            // act
            stopwatch.Start();

            for (var i = 0; i < requestCount; i++)
            {
                var currentRequestTask = OpenWaterHttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://localhost/{i}"), HttpCompletionOption.ResponseContentRead, CancellationToken.None);
                runningRequests.Add(currentRequestTask);
            }

            Task.WhenAll(runningRequests).Wait();
            stopwatch.Stop();

            // assert

            // -1 because we calculate time from 0, not 1
            Assert.That(stopwatch.ElapsedMilliseconds >= (expectedAverageThrottleInSeconds - 1) * MillisecondsInSecond);
            Assert.That(stopwatch.ElapsedMilliseconds <= (expectedAverageThrottleInSeconds + 1) * MillisecondsInSecond);
        }

        [TestCase(1, 1, 5, 5, 42)]
        [TestCase(1, 50, 5, 5, 84)]
        [TestCase(2, 1, 6, 4, 21)]
        [TestCase(50, 50, 50, 1, 99)]
        [TestCase(50, 25, 50, 1, 42)]
        public void SendAsync_ServerDelay_RequestPassesWithExpectedAverageThrottle(int numberOfRequestsPerSecond, int simultaneousRequestsPerSecond, int requestCount, int expectedAverageThrottleInSeconds, int clientBeforeRequestDelayInMilliseconds)
        {
            // arrange
            var mockedResponseMessage = Task.Run(() =>
            {
                Thread.Sleep(clientBeforeRequestDelayInMilliseconds);
                return new HttpResponseMessage(HttpStatusCode.OK);
            });
            var mockedHttpMessageHandler = new MockHttpMessageHandler(mockedResponseMessage);

            HttpClient = new HttpClient(mockedHttpMessageHandler);
            OpenWaterHttpClient = new OpenWaterHttpClient(HttpClient);

            OpenWaterHttpClient.NumberOfRequestsPerSecond = numberOfRequestsPerSecond;
            OpenWaterHttpClient.NumberOfSimultaneousRequests = simultaneousRequestsPerSecond;

            var stopwatch = new Stopwatch();
            var runningRequests = new List<Task>();

            // act
            stopwatch.Start();

            for (var i = 0; i < requestCount; i++)
            {
                var currentRequestTask = OpenWaterHttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"http://localhost/{i}"), HttpCompletionOption.ResponseContentRead, CancellationToken.None);
                runningRequests.Add(currentRequestTask);
            }

            Task.WhenAll(runningRequests).Wait();
            stopwatch.Stop();

            // assert

            // -1 because we calculate time from 0, not 1
            Assert.That(stopwatch.ElapsedMilliseconds >= (expectedAverageThrottleInSeconds - 1) * MillisecondsInSecond);
            Assert.That(stopwatch.ElapsedMilliseconds <= (expectedAverageThrottleInSeconds + 1) * MillisecondsInSecond);
        }
    }
}
