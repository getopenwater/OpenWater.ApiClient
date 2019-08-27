using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

[assembly: InternalsVisibleTo("OpenWater.ApiClient.Tests")]

namespace OpenWater.ApiClient.Extensions
{
    internal static class DateTimeOffsetExtensions
    {
        private const int MillisecondsInSecondCount = 1000;

        internal static int GetThrottleTimeInMilliseconds(this List<DateTimeOffset> self, int maxRequestPerSecondCount, DateTimeOffset currentDateTimeOffset)
        {
            const int minimumRequestCountPerSecondForSmartCalculation = 3;

            lock (self)
            {
                if (self.Count < maxRequestPerSecondCount || maxRequestPerSecondCount < minimumRequestCountPerSecondForSmartCalculation)
                    return MillisecondsInSecondCount / maxRequestPerSecondCount;

                RemoveOutdatedIntervals(self);

                var intervalMilliseconds = self.Last().ToUnixTimeMilliseconds() - self.First().ToUnixTimeMilliseconds();
                var throttleMilliseconds = checked((int)(MillisecondsInSecondCount - intervalMilliseconds));

                if (throttleMilliseconds < 1)
                    return 0;

                return throttleMilliseconds;

            }
        }

        internal static void Throttle(this List<DateTimeOffset> self, int maxRequestsPerSecondCount, DateTimeOffset currentDateTimeOffset)
        {
            Thread.Sleep(self.GetThrottleTimeInMilliseconds(maxRequestsPerSecondCount, currentDateTimeOffset));
        }

        internal static bool RemoveFirstIfAny(this List<DateTimeOffset> self)
        {
            lock (self)
            {
                if (!self.Any())
                    return false;

                self.RemoveAt(0);
                return true;
            }
        }

        internal static void RemoveOutdatedIntervals(List<DateTimeOffset> self)
        {
            const int avgLatencyMilliseconds = 30;
            const int intervalMinElementCount = 2;

            lock (self)
            {
                if (self.Count < intervalMinElementCount)
                    return;

                while (self.Last().Millisecond - self.First().Millisecond >= MillisecondsInSecondCount - avgLatencyMilliseconds)
                {
                    self.RemoveFirstIfAny();
                }
            }
        }

        internal static void AddOrUpdateLast(this List<DateTimeOffset> self, DateTimeOffset oldValue, DateTimeOffset newValue)
        {
            lock (self)
            {
                var searchIndex = self.FindLastIndex(dt => dt == oldValue);
                if (searchIndex == -1)
                {
                    self.Add(newValue);
                    return;
                }

                self[searchIndex] = newValue;
            }
        }
    }
}
