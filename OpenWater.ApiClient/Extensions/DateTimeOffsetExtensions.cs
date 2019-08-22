using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OpenWater.ApiClient.Extensions
{
    internal static class DateTimeOffsetExtensions
    {
        internal static int GetThrottleTimeInMilliseconds(this List<DateTimeOffset> self, int maxRequestPerSecondCount, DateTimeOffset currentDateTimeOffset)
        {
            const int millisecondsInSecond = 1000;

            lock (self)
            {
                if (self.Count < maxRequestPerSecondCount)
                    return 0;

                if (self.Count > 1)
                    self.RemoveFirstIfAny();

                var interval = currentDateTimeOffset.ToUnixTimeMilliseconds() - self.First().ToUnixTimeMilliseconds();
                var throttleMs = checked((int)(interval < millisecondsInSecond ? millisecondsInSecond - interval : 0));

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

        internal static bool ReplaceLastIfAny(this List<DateTimeOffset> self, DateTimeOffset oldValue, DateTimeOffset newValue)
        {
            lock (self)
            {
                var searchIndex = self.FindLastIndex(dt => dt == oldValue);
                if (searchIndex == -1)
                    return false;

                self[searchIndex] = newValue;
                return true;
            }
        }
    }
}
