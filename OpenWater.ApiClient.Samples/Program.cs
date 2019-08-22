using System;

namespace OpenWater.ApiClient.Samples
{
    public class Program
    {
        public static OpenWaterApiClient ApiClient;

        private static void Main()
        {
            ApiClient = new OpenWaterApiClient("demo.secure-platform.com", "41c41e1c-9786-4f79-be44-8e14d4fdc95b");
            //ApiClient = new OpenWaterApiClient("localhost", "some api key", baseUrl: "http://localhost:11100");

            //UserSamples.GetAllUsersAsync();
            //UserSamples.GetAllUsers();
            //UserSamples.GetUsersByNameAsync();
            //UserSamples.GetUsersByName();
            //UserSamples.GetUsersWithPaginationAsync();
            //UserSamples.GetUsersWithPagination();
            //UserSamples.CreateUserAsync();
            //UserSamples.CreateUser();
            //UserSamples.CreateUserAndUpdateProfileAsync();
            //UserSamples.CreateUserAndUpdateProfile();
            //UserSamples.UpdateProfileAsync();
            //UserSamples.UpdateProfile();
            //UserSamples.GetSsoUrlByUserEmailAsync();
            //UserSamples.GetSsoUrlByUserEmail();
            //InvoiceSamples.GetAllInvoicesLastWeekAsync();
            //InvoiceSamples.GetAllInvoicesLastWeek();
            //InvoiceSamples.GetInvoiceByIdAsync();
            //InvoiceSamples.GetInvoiceById();
            //InvoiceSamples.GetAllBillingLineItemsSinceLastWeekAsync();
            //InvoiceSamples.GetAllBillingLineItemsSinceLastWeek();
            //InvoiceSamples.GetAllPaymentsSinceLastWeekAsync();
            //InvoiceSamples.GetAllPaymentsSinceLastWeek();
            //InvoiceSamples.GetAllRefundsSinceLastWeekAsync();
            //InvoiceSamples.GetAllRefundsSinceLastWeek();
            //ReportRunnerSamples.RunReportBackgroundJobAsync();
            //ReportRunnerSamples.RunReportBackgroundJob();
            //ApplicationSamples.CreateNewApplicationAsync();
            //ApplicationSamples.CreateNewApplication();
            //ApplicationSamples.GetApplicationsCreatedInLast24HoursAsync();
            //ApplicationSamples.GetApplicationsCreatedInLast24Hours();
            //ApplicationSamples.UpdateApplicationDataAsync();
            //ApplicationSamples.UpdateApplicationData();
            //ApplicationSamples.UpdateApplicationCategoryAsync();
            //ApplicationSamples.UpdateApplicationCategory();
            //ApplicationSamples.UploadMediaViaUrlAndUpdateSubmissionMediaFieldAsync();
            //ApplicationSamples.UploadMediaViaUrlAndUpdateSubmissionMediaField();
            //ApplicationSamples.UpdateApplicationStatusFromPendingApprovalToCompleteAsync();
            //ApplicationSamples.UpdateApplicationStatusFromPendingApprovalToComplete();
            //ApplicationSamples.UpdateApplicationToAllowUserToMakeEditsAsync();
            //ApplicationSamples.UpdateApplicationToAllowUserToMakeEdits();
            //ApplicationSamples.AssignWinnerAsync();
            //ApplicationSamples.AssignWinner();
            //ApplicationSamples.ForwardToNextRoundAsync();
            //ApplicationSamples.ForwardToNextRound();
            //ApplicationSamples.AddCollaboratorAsync();
            //ApplicationSamples.AddCollaborator();
            //ApplicationSamples.RemoveCollaboratorFromSubmissionAsync();
            //ApplicationSamples.RemoveCollaboratorFromSubmission();
            //ApplicationSamples.GetAllNewApplicationsCreatedOrModifiedLastWeekAsync();
            //ApplicationSamples.GetAllNewApplicationsCreatedOrModifiedLastWeek();
            //ApplicationSamples.ViewDeletedApplicationsInLastWeekAsync();
            //ApplicationSamples.ViewDeletedApplicationsInLastWeek();
            //JudgeSamples.AssignJudgeToApplicationAsync();
            //JudgeSamples.AssignJudgeToApplication();
            //JudgeSamples.RemoveJudgeFromApplicationAsync();
            //JudgeSamples.RemoveJudgeFromApplication();
            //JudgeSamples.AddJudgeToTeamAsync();
            //JudgeSamples.AddJudgeToTeam();
            //JudgeSamples.RemoveJudgeFromTeamAsync();
            //JudgeSamples.RemoveJudgeFromTeam();
            //JudgeAssignmentSamples.GetAllJudgesOnTeamAsync();
            //JudgeAssignmentSamples.GetAllJudgesOnTeam();
            //JudgeAssignmentSamples.GetAllCurrentJudgeAssignmentsForApplicationsAsync();
            //JudgeAssignmentSamples.GetAllCurrentJudgeAssignmentsForApplications();
            //EvaluationSample.GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdAsync();
            //EvaluationSample.GetEvaluationByApplicationIdAndJudgeEmailAndRoundId();
            //EvaluationSample.UpdateEvaluationAsync();
            //EvaluationSample.UpdateEvaluation();
            //SessionSamples.CreateSessionAsync();
            //SessionSamples.CreateSession();
            //SessionSamples.UpdateSessionFieldsAsync();
            //SessionSamples.UpdateSessionFields();
            //SessionSamples.DeleteSessionAsync();
            //SessionSamples.DeleteSession();
            //SessionSamples.GetSessionsCreatedOrModifiedInLastWeekAsync();
            //SessionSamples.GetSessionsCreatedOrModifiedInLastWeek();
            //SessionSamples.GetSessionDataByIdAsync();
            //SessionSamples.GetSessionDataById();
            //SessionChairSamples.AddSessionChairToSessionAsync();
            //SessionChairSamples.AddSessionChairToSession();
            //SessionChairSamples.RemoveSessionChairAsync();
            //SessionChairSamples.RemoveSessionChair();
        }
    }
}
