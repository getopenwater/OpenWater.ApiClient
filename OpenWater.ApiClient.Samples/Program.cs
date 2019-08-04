using System;

namespace OpenWater.ApiClient.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiClient = new OpenWaterApiClient("demo.secure-platform.com", "41c41e1c-9786-4f79-be44-8e14d4fdc95b");
//            var apiClient = new OpenWaterApiClient("localhost", "some api key", baseUrl: "http://localhost:11100");

            GetAllUsers(apiClient);
        }

        private static void GetAllUsers(OpenWaterApiClient apiClient)
        {
            var users = apiClient.UserListAsync(pageSize: 200).Result;
        }
    }
}
