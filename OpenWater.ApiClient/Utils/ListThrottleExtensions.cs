using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OpenWater.ApiClient.Utils
{
    internal static class ListThrottleExtensions
    {
        internal static int GetThrottle(this List<DateTimeOffset> self, int maxRequestsPerSecondCount, DateTimeOffset currentDateTimeOffset)
        {
            lock (self)
            {
                if (self.Count < maxRequestsPerSecondCount) return 0;

                if (self.Count > 1) self.RemoveFirst();

                var interval = currentDateTimeOffset.ToUnixTimeMilliseconds() - self.First().ToUnixTimeMilliseconds();
                var throttleMs = checked((int)(interval < 1000 ? 1000 - interval : 0));

                return throttleMs;

            }
        }

        internal static void Throttle(this List<DateTimeOffset> self, int maxRequestsPerSecondCount, DateTimeOffset currentDateTimeOffset)
        {
            Thread.Sleep(self.GetThrottle(maxRequestsPerSecondCount, currentDateTimeOffset));
        }

        internal static bool RemoveFirst(this List<DateTimeOffset> self)
        {
            lock (self)
            {
                if (self.Count == 0) return false;

                self.RemoveAt(0);
                return true;
            }
        }

        internal static bool Replace(this List<DateTimeOffset> self, DateTimeOffset search, DateTimeOffset replacement)
        {
            lock (self)
            {
                var searchIndex = self.FindLastIndex(dt => dt == search);
                if (searchIndex == -1) return false;

                self[searchIndex] = replacement;
                return true;
            }
        }

        internal static DateTimeOffset AddUtcNow(this List<DateTimeOffset> self)
        {
            var utcNow = DateTimeOffset.UtcNow;
            self.Add(utcNow);

            return utcNow;
        }
    }
}
