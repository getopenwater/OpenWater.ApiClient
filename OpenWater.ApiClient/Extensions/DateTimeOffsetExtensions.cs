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
        const int MillisecondsInSecond = 1000;

        internal static int GetThrottleTimeInMilliseconds(this List<DateTimeOffset> self, int maxRequestPerSecondCount, DateTimeOffset currentDateTimeOffset)
        {
            const int minimumRequestPerSecondForSmartCalculation = 3;

            lock (self)
            {
                if (self.Count < maxRequestPerSecondCount || maxRequestPerSecondCount < minimumRequestPerSecondForSmartCalculation)
                    return MillisecondsInSecond / maxRequestPerSecondCount;

                CleanupIntervalOneSecond(self);

                var interval = self.Last().ToUnixTimeMilliseconds() - self.First().ToUnixTimeMilliseconds();
                var throttleMs = checked((int)(MillisecondsInSecond - interval));

                if (throttleMs < 1)
                    return 0;

                return throttleMs;

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

        internal static void CleanupIntervalOneSecond(List<DateTimeOffset> self)
        {
            const int avgLatency = 30;

            lock (self)
            {
                if(self.Count < 2)
                    return;

                while (self.Last().Millisecond - self.First().Millisecond >= MillisecondsInSecond - avgLatency)
                {
                    self.RemoveFirstIfAny();
                }
            }
        }

        internal static void ReplaceLastIfAnyOrInsert(this List<DateTimeOffset> self, DateTimeOffset oldValue, DateTimeOffset newValue)
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
