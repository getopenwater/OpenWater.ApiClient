using System;
using System.Collections.Generic;
using System.Text;
using OpenWater.ApiClient.FieldValues;
using OpenWater.ApiClient.Session;

namespace OpenWater.ApiClient.Samples
{
    public static partial class Program
    {
        public static void CreateSessionExample()
        {
            var createSessionRequest = new Session.CreateRequest(new List<int>(),
                new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("title", "The best session in the world!")
                }, "session name", 23001, 56001
                );

            ApiClient.CreateSessionAsync(createSessionRequest).Wait();
        }

        public static void UpdateSessionFieldsExample()
        {
            const int sessionId = 53003;
            var model = new FormFieldsRequest(new List<FieldValueModelBase>{ new TextFieldValueModel("title", "Yet another session name") });

            ApiClient.UpdateSessionFormFieldsAsync(sessionId, model).Wait();
        }
        
        public static void DeleteSessionExample()
        {
            const int sessionId = 53003;
            ApiClient.DeleteSessionAsync(sessionId).Wait();
        }
        
        public static PagingResponseSessionListItemModel GetSessionsCreatedOrModifiedInLastWeekExample()
        {
            var lastWeekStart = DateTimeOffset.UtcNow.AddDays(-7);
            var sessions = ApiClient.GetSessionsAsync(lastModifiedSinceUtc: lastWeekStart).Result;

            return sessions;
        }
        
        public static Session.DetailsResponse GetSessionDataByIdExample()
        {
            const int sessionId = 53003;
            var sessionData = ApiClient.GetSessionByIdAsync(sessionId).Result;

            return sessionData;
        }
    }
}
