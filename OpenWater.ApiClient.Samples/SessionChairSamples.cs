using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWater.ApiClient.Samples
{
    public static class SessionChairSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        public static Task AddSessionChairToSessionAsync()
        {
            const int userId = 8004;
            const int sessionId = 53003;

            return ApiClient.CreateSessionChairAsync(new SessionChair.CreateRequest(sessionId, userId));
        }
        public static void AddSessionChairToSession()
        {
            const int userId = 8004;
            const int sessionId = 53003;

            ApiClient.CreateSessionChair(new SessionChair.CreateRequest(sessionId, userId));
        }

        public static Task RemoveSessionChairAsync()
        {
            const int sessionChairId = 54003;

            return ApiClient.DeleteSessionChairAsync(sessionChairId);
        }

        public static void RemoveSessionChair()
        {
            const int sessionChairId = 54003;

            ApiClient.DeleteSessionChair(sessionChairId);
        }
    }
}
