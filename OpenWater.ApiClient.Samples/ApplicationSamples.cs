using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OpenWater.ApiClient.Application;
using OpenWater.ApiClient.FieldValues;
using RoundSubmissionStatusRequestStatus = OpenWater.ApiClient.Application.RoundSubmissionStatusRequestStatus;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {
        public static void CreateNewApplicationExample()
        {
            var createRequest = new Application.CreateRequest(
                "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application")
                }), programId: 23006, userId: 8001
            );

            ApiClient.CreateApplicationAsync(createRequest).Wait();
        }

        public static PagingResponseApplicationListItemModel GetApplicationsCreatedInLast24HoursExample()
        {
            var oneDayAgo = DateTimeOffset.UtcNow.AddDays(-1);
            var applications = ApiClient.ApplicationListAsync(startedAtUtc: oneDayAgo).Result;

            return applications;
        }

        public static void UpdateApplicationDataExample()
        {
            const int applicationId = 18013;
            var submissionRequest = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            }, roundId: 14004);

            ApiClient.UpdateSubmissionFormValuesAsync(applicationId, submissionRequest).Wait();
        }

        public static void UpdateApplicationCategoryExample()
        {
            const int applicationId = 18014;
            var categoryRequest = new ApplicationCategoryRequest("cat1_1_2");

            ApiClient.UpdateApplicationCategoryAsync(applicationId, categoryRequest).Wait();
        }

        public static void UploadMediaViaUrlAndUpdateSubmissionMediaFieldExample()
        {
            const int submissionId = 18028;
            const int roundId = 14001;
            const string mediaUrl = "https://1xpmg62scz1o20xf79413zk4-wpengine.netdna-ssl.com/wp-content/uploads/2019/07/Mobile-Friendly-Abstract-Submissions.png";
            var mediaName = Path.GetFileNameWithoutExtension(mediaUrl);

            var media = ApiClient.CreateMediaAsync(new Media.CreateRequest(mediaName, mediaUrl)).Result;

            var submissionForm = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new FileUploadFieldValueModel("sampleForm", "caption", media.MediaId)
            }, roundId);

            ApiClient.UpdateSubmissionFormValuesAsync(submissionId, submissionForm).Wait();
        }

        public static void UpdateApplicationStatusFromPendingApprovalToComplete()
        {
            const int applicationId = 18028;
            const int roundId = 14001;

            ApiClient.RoundSubmissionStatusAsync(applicationId, roundId,
                new RoundSubmissionStatusRequest(RoundSubmissionStatusRequestStatus.Complete)).Wait();
        }

        public static void UpdateApplicationToAllowUserToMakeEditsExample()
        {
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.AllowUserToMakeEditsAsync(applicationId, roundId, new AllowUserToMakeEditsRequest(true)).Wait();
        }

        public static void AssignWinnerExample()
        {
            const int applicationId = 18013;
            const int roundId = 14004;
            var winnerAssignmentRequest = new WinnerAssignmentRequest(true, "notes", new List<int>());

            ApiClient.WinnerAssignmentAsync(applicationId, roundId, winnerAssignmentRequest).Wait();
        }
        
        public static void ForwardToNextRoundExample()
        {
            const int applicationId = 18028;
            const int nextRoundId   = 14006;

            ApiClient.ForwardingAsync(applicationId, nextRoundId, new ForwardingRequest(true)).Wait();
        }

        public static void AddCollaboratorExample()
        {
            const int applicationId = 18001;
            const int userId = 8001;

            ApiClient.CreateCollaboratorAsync(applicationId, new Collaborator.CreateRequest(true, userId)).Wait();
        }

        public static void RemoveCollaboratorFromSubmissionExample()
        {
            const int applicationId  = 18001;
            const int collaboratorId = 19001;

            ApiClient.DeleteCollaboratorAsync(applicationId, collaboratorId).Wait();
        }

        public static void ViewAllNewApplicationsCreatedOrModifiedLastWeekExample()
        {
            var currentWeekStart = DateTimeOffset.UtcNow.AddDays(-7);
            var applications = ApiClient.ApplicationListAsync(lastModifiedSinceUtc: currentWeekStart).Result;

            applications.Items.ToList().ForEach(a =>
                Console.WriteLine("Id: {0}. Name: {1}. Last modified at: {2}.", a.Id, a.Name, a.LastModifiedUtc));
        }
        
        public static void ViewDeletedApplicationsInLastWeekExample()
        {
            var currentWeekStart = DateTimeOffset.UtcNow.AddDays(-7);
            var deletedApplications = ApiClient.DeletedApplicationListAsync(deletedSinceUtc: currentWeekStart).Result;

            deletedApplications.Items.ToList().ForEach(d =>
                Console.WriteLine("Id: {0}. Name: {1}. Deleted at: {2}", d.Id, d.ApplicationName, d.DeletedAtUtc));
        }
    }
}
