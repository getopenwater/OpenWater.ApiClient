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
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Create session async.
        /// </summary>
        public static Task<DetailsResponse> CreateSessionAsync()
        {
            const int programId = 23001;
            const int typeId = 56001;

            var createSessionRequest = new CreateRequest(new List<int>(),
                new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("title", "The best session in the world!")
                }, "session name", programId, typeId
            );

            return ApiClient.CreateSessionAsync(createSessionRequest);
        }

        /// <summary>
        /// Create session.
        /// </summary>
        public static DetailsResponse CreateSession()
        {
            const int programId = 23001;
            const int typeId = 56001;

            var createSessionRequest = new CreateRequest(new List<int>(),
                new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("title", "The best session in the world!")
                }, "session name", programId, typeId
            );

            return ApiClient.CreateSession(createSessionRequest);
        }

        /// <summary>
        /// Update title field of session with id 53003 async.
        /// </summary>
        public static Task UpdateSessionFieldsAsync()
        {
            const int sessionId = 53003;
            var model = new FormFieldsRequest(new List<FieldValueModelBase> { new TextFieldValueModel("title", "Yet another session name") });

            return ApiClient.UpdateSessionFormFieldsAsync(sessionId, model);
        }

        /// <summary>
        /// Update title field of session with id 53003.
        /// </summary>
        public static void UpdateSessionFields()
        {
            const int sessionId = 53003;
            var model = new FormFieldsRequest(new List<FieldValueModelBase> { new TextFieldValueModel("title", "Yet another session name") });

            ApiClient.UpdateSessionFormFields(sessionId, model);
        }

        /// <summary>
        /// Delete session with id 53003 async.
        /// </summary>
        public static Task DeleteSessionAsync()
        {
            const int sessionId = 53003;

            return ApiClient.DeleteSessionAsync(sessionId);
        }

        /// <summary>
        /// Delete session with id 53003.
        /// </summary>
        public static void DeleteSession()
        {
            const int sessionId = 53003;

            ApiClient.DeleteSession(sessionId);
        }

        /// <summary>
        /// Get session created or modified in last week async.
        /// </summary>
        public static Task<PagingResponseSessionListItemModel> GetSessionsCreatedOrModifiedInLastWeekAsync()
        {
            return ApiClient.GetSessionsAsync(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get session created or modified in last week.
        /// </summary>
        public static PagingResponseSessionListItemModel GetSessionsCreatedOrModifiedInLastWeek()
        {
            return ApiClient.GetSessions(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get session data with id 53003 async.
        /// </summary>
        public static Task<DetailsResponse> GetSessionDataByIdAsync()
        {
            const int sessionId = 53003;

            return ApiClient.GetSessionByIdAsync(sessionId);
        }

        /// <summary>
        /// Get session data with id 53003.
        /// </summary>
        public static DetailsResponse GetSessionDataById()
        {
            const int sessionId = 53003;

            return ApiClient.GetSessionById(sessionId);
        }
    }
}