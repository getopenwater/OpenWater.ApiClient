using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWater.ApiClient.Samples
{
    public static partial class Program
    {
        public static void AddSessionChairToSessionExample()
        {
            const int userId = 8004;
            const int sessionId = 53003;

            ApiClient.CreateSessionChairAsync(new SessionChair.CreateRequest(sessionId, userId)).Wait();
        }

        public static void RemoveSessionChairExample()
        {
            const int sessionChairId = 54003;

            ApiClient.DeleteSessionChairAsync(sessionChairId).Wait();
        }
    }
}
