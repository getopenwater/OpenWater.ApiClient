using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWater.ApiClient.Samples
{
    public static class SessionChairSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task AddSessionChairToSessionAsync()
        {
            const int userId = 8004;
            const int sessionId = 53003;

            await ApiClient.CreateSessionChairAsync(new SessionChair.CreateRequest(sessionId, userId));
        }

        public static async Task RemoveSessionChairAsync()
        {
            const int sessionChairId = 54003;

            await ApiClient.DeleteSessionChairAsync(sessionChairId);
        }
    }
}
