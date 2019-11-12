using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using OpenWater.ApiClient.Application;
using OpenWater.ApiClient.Definitions;
using OpenWater.ApiClient.FieldValues;

namespace OpenWater.ApiClient.Samples
{
    public class ApplicationSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Create application named "Application 42" async
        /// </summary>
        public static Task<DetailsResponse> CreateNewApplicationAsync()
        {
            const int programId = 23006;
            const int userId = 8001;
            var createRequest = new CreateRequest(programId, userId, "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application")
                })
            );

            return ApiClient.CreateApplicationAsync(createRequest);
        }

        /// <summary>
        /// Create application named "Application 42"
        /// </summary>
        public static DetailsResponse CreateNewApplication()
        {
            const int programId = 23006;
            const int userId = 8001;
            var createRequest = new CreateRequest(programId, userId, "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application")
                })
            );

            return ApiClient.CreateApplication(createRequest);
        }

        /// <summary>
        /// Get applications created in last 24 hours async
        /// </summary>
        public static Task<PagingResponseApplicationListItemModel> GetApplicationsCreatedInLast24HoursAsync()
        {
            return ApiClient.GetApplicationsAsync(startedAtUtc: DateTimeOffset.UtcNow.AddDays(-1));
        }

        /// <summary>
        /// Get applications created in last 24 hours
        /// </summary>
        public static PagingResponseApplicationListItemModel GetApplicationsCreatedInLast24Hours()
        {
            return ApiClient.GetApplications(startedAtUtc: DateTimeOffset.UtcNow.AddDays(-1));
        }

        /// <summary>
        /// Update application by id 18013 and round id 14004 title to "Updated Application" async
        /// </summary>
        public static Task UpdateApplicationDataAsync()
        {
            const int applicationId = 18013;
            const int roundId = 14004;

            var submissionRequest = new UpdateRoundSubmissionFormValuesRequest(roundId, new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            });

            return ApiClient.UpdateRoundSubmissionFormValuesAsync(applicationId, submissionRequest);
        }

        /// <summary>
        /// Update application by id 18013 and round id 14004 title to "Updated Application" 
        /// </summary>
        public static void UpdateApplicationData()
        {
            const int applicationId = 18013;
            const int roundId = 14004;

            var submissionRequest = new UpdateRoundSubmissionFormValuesRequest(roundId, new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            });

            ApiClient.UpdateRoundSubmissionFormValues(applicationId, submissionRequest);
        }

        /// <summary>
        /// Update application by id 14014 category to "cat1_1_2" async
        /// </summary>
        public static Task UpdateApplicationCategoryAsync()
        {
            const int applicationId = 18014;

            return ApiClient.UpdateApplicationCategoryAsync(applicationId, new UpdateApplicationCategoryRequest("cat1_1_2"));
        }

        /// <summary>
        /// Update application by id 14014 category to "cat1_1_2"
        /// </summary>
        public static void UpdateApplicationCategory()
        {
            const int applicationId = 18014;

            ApiClient.UpdateApplicationCategory(applicationId, new UpdateApplicationCategoryRequest("cat1_1_2"));
        }

        /// <summary>
        /// Upload media via Url and update submission by application id 18028  and round id 14001 media field async
        /// </summary>
        public static async Task UploadMediaViaUrlAndUpdateSubmissionMediaFieldAsync()
        {
            const int applicationId = 18028;
            const int roundId = 14001;
            const string mediaUrl = "https://1xpmg62scz1o20xf79413zk4-wpengine.netdna-ssl.com/wp-content/uploads/2019/07/Mobile-Friendly-Abstract-Submissions.png";
            var mediaName = Path.GetFileNameWithoutExtension(mediaUrl);
            var media = await ApiClient.CreateMediaAsync(new Media.CreateRequest(mediaName, mediaUrl));

            var submissionForm = new UpdateRoundSubmissionFormValuesRequest(roundId, new List<FieldValueModelBase>
            {
                new FileUploadFieldValueModel("sampleForm", "caption", media.MediaId)
            });

            await ApiClient.UpdateRoundSubmissionFormValuesAsync(applicationId, submissionForm);
        }

        /// <summary>
        /// Upload media via Url and update submission by application id 18028  and round id 14001 media field
        /// </summary>
        public static void UploadMediaViaUrlAndUpdateSubmissionMediaField()
        {
            const int applicationId = 18028;
            const int roundId = 14001;
            const string mediaUrl = "https://1xpmg62scz1o20xf79413zk4-wpengine.netdna-ssl.com/wp-content/uploads/2019/07/Mobile-Friendly-Abstract-Submissions.png";
            var mediaName = Path.GetFileNameWithoutExtension(mediaUrl);
            var media = ApiClient.CreateMedia(new Media.CreateRequest(mediaName, mediaUrl));

            var submissionForm = new UpdateRoundSubmissionFormValuesRequest(roundId, new List<FieldValueModelBase>
            {
                new FileUploadFieldValueModel("caption","sampleForm", media.MediaId)
            });

            ApiClient.UpdateRoundSubmissionFormValues(applicationId, submissionForm);
        }

        /// <summary>
        /// Update application by id 18028 and round id 14001 and change status from pending approval to complete async
        /// </summary>
        public static Task UpdateApplicationStatusFromPendingApprovalToCompleteAsync()
        {
            const int applicationId = 18028;
            const int roundId = 14001;

            return ApiClient.ChangeFinalizedRoundSubmissionStatusAsync(applicationId, roundId, new ChangeFinalizedRoundSubmissionStatusRequest(SubmissionStatus.Complete));
        }

        /// <summary>
        /// Update application by id 18028 and round id 14001 and change status from pending approval to complete
        /// </summary>
        public static void UpdateApplicationStatusFromPendingApprovalToComplete()
        {
            const int applicationId = 18028;
            const int roundId = 14001;

            ApiClient.ChangeFinalizedRoundSubmissionStatus(applicationId, roundId, new ChangeFinalizedRoundSubmissionStatusRequest(SubmissionStatus.Complete));
        }

        /// <summary>
        /// Update application to allow user to make edits by id 18015 abd round id 14004 async
        /// </summary>
        public static Task UpdateApplicationToAllowUserToMakeEditsAsync()
        {
            const int applicationId = 18015;
            const int roundId = 14004;

            return ApiClient.AllowUserToUpdateFinalizedRoundSubmissionAsync(applicationId, roundId, new AllowUserToUpdateFinalizedRoundSubmissionRequest(true));
        }

        /// <summary>
        /// Update application to allow user to make edits by id 18015 abd round id 14004
        /// </summary>
        public static void UpdateApplicationToAllowUserToMakeEdits()
        {
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.AllowUserToUpdateFinalizedRoundSubmission(applicationId, roundId, new AllowUserToUpdateFinalizedRoundSubmissionRequest(true));
        }

        /// <summary>
        /// Assign winner to application by id 18013 and round id 14004 async
        /// </summary>
        public static Task AssignWinnerAsync()
        {
            const int applicationId = 18013;
            const int roundId = 14004;
            var winnerAssignmentRequest = new SetWinnerStatusForApplicationInRoundRequest(true, "notes", new List<int>());

            return ApiClient.SetWinnerStatusForApplicationInRoundAsync(applicationId, roundId, winnerAssignmentRequest);
        }

        /// <summary>
        /// Assign winner to application by id 18013 and round id 14004
        /// </summary>
        public static void AssignWinner()
        {
            const int applicationId = 18013;
            const int roundId = 14004;
            var winnerAssignmentRequest = new SetWinnerStatusForApplicationInRoundRequest(true, "notes", new List<int>());

            ApiClient.SetWinnerStatusForApplicationInRound(applicationId, roundId, winnerAssignmentRequest);
        }

        /// <summary>
        /// Forward application by id 18028 to next round by id 14006 async
        /// </summary>
        public static Task ForwardToNextRoundAsync()
        {
            const int applicationId = 18028;
            const int nextRoundId = 14006;

            return ApiClient.SetForwardingStatusForApplicationInRoundAsync(applicationId, nextRoundId, new SetForwardingStatusForApplicationInRoundRequest(true));
        }

        /// <summary>
        /// Forward application by id 18028 to next round by id 14006
        /// </summary>
        public static void ForwardToNextRound()
        {
            const int applicationId = 18028;
            const int nextRoundId = 14006;

            ApiClient.SetForwardingStatusForApplicationInRound(applicationId, nextRoundId, new SetForwardingStatusForApplicationInRoundRequest(true));
        }

        /// <summary>
        /// Add collaborator by id 8001 to application by id 18001 async
        /// </summary>
        public static Task AddCollaboratorAsync()
        {
            const int applicationId = 18001;
            const int userId = 8001;

            return ApiClient.CreateApplicationCollaboratorAsync(applicationId, new Collaborator.CreateRequest(userId, true));
        }

        /// <summary>
        /// Add collaborator by id 8001 to application by id 18001
        /// </summary>
        public static void AddCollaborator()
        {
            const int applicationId = 18001;
            const int userId = 8001;

            ApiClient.CreateApplicationCollaborator(applicationId, new Collaborator.CreateRequest(userId, true));
        }

        /// <summary>
        /// Remove collaborator by id 8001 from application by id 18001 async
        /// </summary>
        public static Task RemoveCollaboratorFromSubmissionAsync()
        {
            const int applicationId = 18001;
            const int collaboratorId = 19001;

            return ApiClient.DeleteApplicationCollaboratorAsync(applicationId, collaboratorId);
        }

        /// <summary>
        /// Remove collaborator by id 8001 from application by id 18001
        /// </summary>
        public static void RemoveCollaboratorFromSubmission()
        {
            const int applicationId = 18001;
            const int collaboratorId = 19001;

            ApiClient.DeleteApplicationCollaborator(applicationId, collaboratorId);
        }

        /// <summary>
        /// Get all new applications created or modified last week async
        /// </summary>
        public static Task<PagingResponseApplicationListItemModel> GetAllNewApplicationsCreatedOrModifiedLastWeekAsync()
        {
            return ApiClient.GetApplicationsAsync(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get all new applications created or modified last week
        /// </summary>
        public static PagingResponseApplicationListItemModel GetAllNewApplicationsCreatedOrModifiedLastWeek()
        {
            return ApiClient.GetApplications(lastModifiedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get deleted applications in last week async
        /// </summary>
        public static Task<DeletedApplication.PagingResponseDeletedApplicationListItem>
            ViewDeletedApplicationsInLastWeekAsync()
        {
            return ApiClient.GetDeletedApplicationsAsync(deletedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get deleted applications in last week
        /// </summary>
        public static DeletedApplication.PagingResponseDeletedApplicationListItem ViewDeletedApplicationsInLastWeek()
        {
            return ApiClient.GetDeletedApplications(deletedSinceUtc: DateTimeOffset.UtcNow.AddDays(-7));
        }
    }
}