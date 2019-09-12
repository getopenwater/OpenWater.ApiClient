using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWater.ApiClient.Samples
{
    public static class SessionChairSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Add session chair with user by id 8004 to session by id 53003 async
        /// </summary>
        public static Task AddSessionChairToSessionAsync()
        {
            const int userId = 8004;
            const int sessionId = 53003;

            return ApiClient.CreateSessionChairAsync(new SessionChair.CreateRequest(sessionId, userId));
        }

        /// <summary>
        /// Add session chair with user by id 8004 to session by id 53003
        /// </summary>
        public static void AddSessionChairToSession()
        {
            const int userId = 8004;
            const int sessionId = 53003;

            ApiClient.CreateSessionChair(new SessionChair.CreateRequest(sessionId, userId));
        }

        /// <summary>
        /// Remove session chair by id 54003 async
        /// </summary>
        public static Task RemoveSessionChairAsync()
        {
            const int sessionChairId = 54003;

            return ApiClient.DeleteSessionChairAsync(sessionChairId);
        }

        /// <summary>
        /// Remove session chair by id 54003
        /// </summary>
        public static void RemoveSessionChair()
        {
            const int sessionChairId = 54003;

            ApiClient.DeleteSessionChair(sessionChairId);
        }
    }
}