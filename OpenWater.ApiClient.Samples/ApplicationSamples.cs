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
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Create application named "Application 42" async.
        /// </summary>
        public static Task<DetailsResponse> CreateNewApplicationAsync()
        {
            const int programId = 23006;
            const int userId = 8001;
            var createRequest = new Application.CreateRequest(
                "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application")
                }), programId, userId
            );

            return ApiClient.CreateApplicationAsync(createRequest);
        }

        /// <summary>
        /// Create application named "Application 42".
        /// </summary>
        public static DetailsResponse CreateNewApplication()
        {
            const int programId = 23006;
            const int userId = 8001;
            var createRequest = new Application.CreateRequest(
                "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application")
                }), programId, userId
            );

            return ApiClient.CreateApplication(createRequest);
        }

        /// <summary>
        /// Get applications created in last 24 hours async.
        /// </summary>
        public static Task<PagingResponseApplicationListItemModel> GetApplicationsCreatedInLast24HoursAsync()
        {
            return ApiClient.ApplicationListAsync(startedAtUtc: DateTimeOffset.UtcNow.AddDays(-1));
        }

        /// <summary>
        /// Get applications created in last 24 hours.
        /// </summary>
        public static PagingResponseApplicationListItemModel GetApplicationsCreatedInLast24Hours()
        {
            return ApiClient.ApplicationList(startedAtUtc: DateTimeOffset.UtcNow.AddDays(-1));
        }

        /// <summary>
        /// Update application with id 18013 and round 14004: set value for field with alias "title" async.
        /// </summary>
        public static Task UpdateApplicationDataAsync()
        {
            const int applicationId = 18013;
            const int roundId = 14004;

            var submissionRequest = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            }, roundId);

            return ApiClient.UpdateSubmissionFormValuesAsync(applicationId, submissionRequest);
        }

        /// <summary>
        /// Update application with id 18013 and round 14004: set value for field with alias "title".
        /// </summary>
        public static void UpdateApplicationData()
        {
            const int applicationId = 18013;
            const int roundId = 14004;

            var submissionRequest = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            }, roundId);

            ApiClient.UpdateSubmissionFormValues(applicationId, submissionRequest);
        }

        /// <summary>
        /// Change category of application with id 14014 to "cat1_1_2" async.
        /// </summary>
        public static Task UpdateApplicationCategoryAsync()
        {
            const int applicationId = 18014;

            return ApiClient.UpdateApplicationCategoryAsync(applicationId, new ApplicationCategoryRequest("cat1_1_2"));
        }

        /// <summary>
        /// Change category of application with id 14014 to "cat1_1_2".
        /// </summary>
        public static void UpdateApplicationCategory()
        {
            const int applicationId = 18014;

            ApiClient.UpdateApplicationCategory(applicationId, new ApplicationCategoryRequest("cat1_1_2"));
        }

        /// <summary>
        /// Upload media via Url and attach it to media field of application with id 18028 into media field async.
        /// </summary>
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

        /// <summary>
        /// Upload media via Url and attach it to media field of application with id 18028 into media field.
        /// </summary>
        public static void UploadMediaViaUrlAndUpdateSubmissionMediaField()
        {
            const int applicationId = 18028;
            const int roundId = 14001;
            const string mediaUrl =
                "https://1xpmg62scz1o20xf79413zk4-wpengine.netdna-ssl.com/wp-content/uploads/2019/07/Mobile-Friendly-Abstract-Submissions.png";
            var mediaName = Path.GetFileNameWithoutExtension(mediaUrl);
            var media = ApiClient.CreateMedia(new Media.CreateRequest(mediaName, mediaUrl));

            var submissionForm = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new FileUploadFieldValueModel("sampleForm", "caption", media.MediaId)
            }, roundId);

            ApiClient.UpdateSubmissionFormValues(applicationId, submissionForm);
        }

        /// <summary>
        /// Update application with id 18028 and round id 14001 and change status from pending approval to complete async.
        /// </summary>
        public static Task UpdateApplicationStatusFromPendingApprovalToCompleteAsync()
        {
            const int applicationId = 18028;
            const int roundId = 14001;

            return ApiClient.RoundSubmissionStatusAsync(applicationId, roundId,
                new RoundSubmissionStatusRequest(RoundSubmissionStatusRequestStatus.Complete));
        }

        /// <summary>
        /// Update application with id 18028 and round id 14001 and change status from pending approval to complete.
        /// </summary>
        public static void UpdateApplicationStatusFromPendingApprovalToComplete()
        {
            const int applicationId = 18028;
            const int roundId = 14001;

            ApiClient.RoundSubmissionStatus(applicationId, roundId, new RoundSubmissionStatusRequest(RoundSubmissionStatusRequestStatus.Complete));
        }

        /// <summary>
        /// Allow user to make edits on application with id 18015 and round id 14004 async.
        /// </summary>
        public static Task UpdateApplicationToAllowUserToMakeEditsAsync()
        {
            const int applicationId = 18015;
            const int roundId = 14004;

            return ApiClient.AllowUserToMakeEditsAsync(applicationId, roundId, new AllowUserToMakeEditsRequest(true));
        }

        /// <summary>
        /// Allow user to make edits on application with id 18015 and round id 14004.
        /// </summary>
        public static void UpdateApplicationToAllowUserToMakeEdits()
        {
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.AllowUserToMakeEdits(applicationId, roundId, new AllowUserToMakeEditsRequest(true));
        }

        /// <summary>
        /// Assign winner to application with id 18013 and round id 14004 async.
        /// </summary>
        public static Task AssignWinnerAsync()
        {
            const int applicationId = 18013;
            const int roundId = 14004;
            var winnerAssignmentRequest = new WinnerAssignmentRequest(true, "notes", new List<int>());

            return ApiClient.WinnerAssignmentAsync(applicationId, roundId, winnerAssignmentRequest);
        }

        /// <summary>
        /// Assign winner to application with id 18013 and round id 14004.
        /// </summary>
        public static void AssignWinner()
        {
            const int applicationId = 18013;
            const int roundId = 14004;
            var winnerAssignmentRequest = new WinnerAssignmentRequest(true, "notes", new List<int>());

            ApiClient.WinnerAssignment(applicationId, roundId, winnerAssignmentRequest);
        }

        /// <summary>
        /// Forward application with id 18028 to next round with id 14006 async.
        /// </summary>
        public static Task ForwardToNextRoundAsync()
        {
            const int applicationId = 18028;
            const int nextRoundId = 14006;

            return ApiClient.ForwardingAsync(applicationId, nextRoundId, new ForwardingRequest(true));
        }

        /// <summary>
        /// Forward application with id 18028 to next round with id 14006.
        /// </summary>
        public static void ForwardToNextRound()
        {
            const int applicationId = 18028;
            const int nextRoundId = 14006;

            ApiClient.Forwarding(applicationId, nextRoundId, new ForwardingRequest(true));
        }

        /// <summary>
        /// Add collaborator with id 8001 to application with id 18001 async.
        /// </summary>
        public static Task AddCollaboratorAsync()
        {
            const int applicationId = 18001;
            const int userId = 8001;

            return ApiClient.CreateCollaboratorAsync(applicationId, new Collaborator.CreateRequest(true, userId));
        }

        /// <summary>
        /// Add collaborator with id 8001 to application with id 18001.
        /// </summary>
        public static void AddCollaborator()
        {
            const int applicationId = 18001;
            const int userId = 8001;

            ApiClient.CreateCollaborator(applicationId, new Collaborator.CreateRequest(true, userId));
        }

        /// <summary>
        /// Remove collaborator with id 8001 from application with id 18001 async.
        /// </summary>
        public static Task RemoveCollaboratorFromSubmissionAsync()
        {
            const int applicationId = 18001;
            const int collaboratorId = 19001;

            return ApiClient.DeleteCollaboratorAsync(applicationId, collaboratorId);
        }

        /// <summary>
        /// Remove collaborator with id 8001 from application with id 18001.
        /// </summary>
        public static void RemoveCollaboratorFromSubmission()
        {
            const int applicationId = 18001;
            const int collaboratorId = 19001;

            ApiClient.DeleteCollaborator(applicationId, collaboratorId);
        }

        /// <summary>
        /// Get all new applications created or modified last week async.
        /// </summary>
        public static Task<PagingResponseApplicationListItemModel> GetAllNewApplicationsCreatedOrModifiedLastWeekAsync()
        {
            return ApiClient.ApplicationListAsync(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get all new applications created or modified last week.
        /// </summary>
        public static PagingResponseApplicationListItemModel GetAllNewApplicationsCreatedOrModifiedLastWeek()
        {
            return ApiClient.ApplicationList(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get deleted applications in last week async.
        /// </summary>
        public static Task<DeletedApplication.PagingResponseDeletedApplicationListItem>
            ViewDeletedApplicationsInLastWeekAsync()
        {
            return ApiClient.DeletedApplicationListAsync(deletedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get deleted applications in last week.
        /// </summary>
        public static DeletedApplication.PagingResponseDeletedApplicationListItem ViewDeletedApplicationsInLastWeek()
        {
            return ApiClient.DeletedApplicationList(deletedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }
    }
}