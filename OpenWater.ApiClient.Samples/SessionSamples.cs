﻿using System;
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

        public static Task CreateSessionAsync()
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

        public static async Task UpdateSessionFieldsAsync()
        {
            const int sessionId = 53003;
            var model = new FormFieldsRequest(new List<FieldValueModelBase> { new TextFieldValueModel("title", "Yet another session name") });

            await ApiClient.UpdateSessionFormFieldsAsync(sessionId, model);
        }

        public static Task DeleteSessionAsync()
        {
            const int sessionId = 53003;

            return ApiClient.DeleteSessionAsync(sessionId);
        }

        public static Task<PagingResponseSessionListItemModel> GetSessionsCreatedOrModifiedInLastWeekAsync()
        {
            return ApiClient.GetSessionsAsync(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        public static Task<DetailsResponse> GetSessionDataByIdAsync()
        {
            const int sessionId = 53003;

            return ApiClient.GetSessionByIdAsync(sessionId);
        }
    }
}
