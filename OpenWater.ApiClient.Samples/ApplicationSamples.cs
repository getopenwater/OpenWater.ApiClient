using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OpenWater.ApiClient.Application;
using OpenWater.ApiClient.FieldValues;
using RoundSubmissionStatusRequestStatus = OpenWater.ApiClient.Application.RoundSubmissionStatusRequestStatus;

namespace OpenWater.ApiClient.Samples
{
    public class ApplicationSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task CreateNewApplicationAsync()
        {
            var createRequest = new Application.CreateRequest(
                "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application")
                }), programId: 23006, userId: 8001
            );

            await ApiClient.CreateApplicationAsync(createRequest);
        }

        public static async Task<PagingResponseApplicationListItemModel> GetApplicationsCreatedInLast24HoursAsync()
        {
            var applications = ApiClient.ApplicationListAsync(startedAtUtc: DateTimeOffset.UtcNow.AddDays(-1));

            return await applications;
        }

        public static async Task UpdateApplicationDataAsync()
        {
            const int applicationId = 18013;
            var submissionRequest = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            }, roundId: 14004);

            await ApiClient.UpdateSubmissionFormValuesAsync(applicationId, submissionRequest);
        }

        public static async Task UpdateApplicationCategoryAsync()
        {
            const int applicationId = 18014;

            await ApiClient.UpdateApplicationCategoryAsync(applicationId, new ApplicationCategoryRequest("cat1_1_2"));
        }

        public static async Task UploadMediaViaUrlAndUpdateSubmissionMediaFieldAsync()
        {
            const int applicationId = 18028;
            const int roundId = 14001;
            const string mediaUrl =
                "https://1xpmg62scz1o20xf79413zk4-wpengine.netdna-ssl.com/wp-content/uploads/2019/07/Mobile-Friendly-Abstract-Submissions.png";
            var mediaName = Path.GetFileNameWithoutExtension(mediaUrl);
            var media = await ApiClient.CreateMediaAsync(new Media.CreateRequest(mediaName, mediaUrl));

            var submissionForm = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new FileUploadFieldValueModel("sampleForm", "caption", media.MediaId)
            }, roundId);

            await ApiClient.UpdateSubmissionFormValuesAsync(applicationId, submissionForm);
        }

        public static async Task UpdateApplicationStatusFromPendingApprovalToCompleteAsync()
        {
            const int applicationId = 18028;
            const int roundId = 14001;

            await ApiClient.RoundSubmissionStatusAsync(applicationId, roundId, new RoundSubmissionStatusRequest(RoundSubmissionStatusRequestStatus.Complete));
        }

        public static async Task UpdateApplicationToAllowUserToMakeEditsAsync()
        {
            const int applicationId = 18015;
            const int roundId = 14004;

            await ApiClient.AllowUserToMakeEditsAsync(applicationId, roundId, new AllowUserToMakeEditsRequest(true));
        }

        public static async Task AssignWinnerAsync()
        {
            const int applicationId = 18013;
            const int roundId = 14004;
            var winnerAssignmentRequest = new WinnerAssignmentRequest(true, "notes", new List<int>());

            await ApiClient.WinnerAssignmentAsync(applicationId, roundId, winnerAssignmentRequest);
        }

        public static async Task ForwardToNextRoundAsync()
        {
            const int applicationId = 18028;
            const int nextRoundId   = 14006;

            await ApiClient.ForwardingAsync(applicationId, nextRoundId, new ForwardingRequest(true));
        }

        public static async Task AddCollaboratorAsync()
        {
            const int applicationId = 18001;
            const int userId = 8001;

            await ApiClient.CreateCollaboratorAsync(applicationId, new Collaborator.CreateRequest(true, userId));
        }

        public static async Task RemoveCollaboratorFromSubmissionAsync()
        {
            const int applicationId  = 18001;
            const int collaboratorId = 19001;

            await ApiClient.DeleteCollaboratorAsync(applicationId, collaboratorId);
        }

        public static async Task<PagingResponseApplicationListItemModel>
            GetAllNewApplicationsCreatedOrModifiedLastWeekAsync()
        {
            var applications = ApiClient.ApplicationListAsync(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));

            return await applications;
        }

        public static async Task<DeletedApplication.PagingResponseDeletedApplicationListItem> ViewDeletedApplicationsInLastWeekAsync()
        {
            var deletedApplications = ApiClient.DeletedApplicationListAsync(deletedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));

            return await deletedApplications;
        }
    }
}
