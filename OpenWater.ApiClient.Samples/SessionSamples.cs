using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenWater.ApiClient.FieldValues;
using OpenWater.ApiClient.Session;

namespace OpenWater.ApiClient.Samples
{
    public static class SessionSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task CreateSessionAsync()
        {
            const string sessionName = "session name";
            var createSessionRequest = new CreateRequest(new List<int>(),
                new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("title", "The best session in the world!")
                }, sessionName, programId: 23001, typeId: 56001
            );

            await ApiClient.CreateSessionAsync(createSessionRequest);
        }

        public static async Task UpdateSessionFieldsAsync()
        {
            const int sessionId = 53003;
            var model = new FormFieldsRequest(new List<FieldValueModelBase> { new TextFieldValueModel("title", "Yet another session name") });

            await ApiClient.UpdateSessionFormFieldsAsync(sessionId, model);
        }

        public static async Task DeleteSessionAsync()
        {
            const int sessionId = 53003;

            await ApiClient.DeleteSessionAsync(sessionId);
        }

        public static async Task<PagingResponseSessionListItemModel> GetSessionsCreatedOrModifiedInLastWeekAsync()
        {
            var sessions = ApiClient.GetSessionsAsync(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));

            return await sessions;
        }

        public static async Task<DetailsResponse> GetSessionDataByIdAsync()
        {
            const int sessionId = 53003;

            var sessionData = ApiClient.GetSessionByIdAsync(sessionId);

            return await sessionData;
        }
    }
}
