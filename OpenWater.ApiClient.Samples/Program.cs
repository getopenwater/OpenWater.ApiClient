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
            //UserSamples.GetUsersByNameAsync();
            //UserSamples.GetUsersWithPaginationAsync();
            //UserSamples.CreateUserAsync();
            //UserSamples.CreateUserAndGetThatUserAsync();
            //UserSamples.CreateUserAndUpdateProfileAsync();
            //UserSamples.UpdateProfileAsync();
            //UserSamples.GetSsoUrlByUserEmailAsync();
            //InvoiceSamples.GetAllInvoicesLastWeekAsync();
            //InvoiceSamples.GetInvoiceByIdAsync();
            //InvoiceSamples.GetAllBillingLineItemsSinceLastWeekAsync();
            //InvoiceSamples.GetAllPaymentsSinceLastWeekAsync();
            //InvoiceSamples.GetAllRefundsSinceLastWeek();
            //ReportRunnerSamples.RunReportBackgroundJobAsync();
            //ApplicationSamples.CreateNewApplicationAsync();
            //ApplicationSamples.GetApplicationsCreatedInLast24HoursAsync();
            //ApplicationSamples.UpdateApplicationDataAsync();
            //ApplicationSamples.UpdateApplicationCategoryAsync();
            //ApplicationSamples.UploadMediaViaUrlAndUpdateSubmissionMediaFieldAsync();
            //ApplicationSamples.UpdateApplicationStatusFromPendingApprovalToCompleteAsync();
            //ApplicationSamples.UpdateApplicationToAllowUserToMakeEditsAsync();
            //ApplicationSamples.AssignWinnerAsync();
            //ApplicationSamples.ForwardToNextRoundAsync();
            //ApplicationSamples.AddCollaboratorAsync();
            //ApplicationSamples.RemoveCollaboratorFromSubmissionAsync();
            //ApplicationSamples.GetAllNewApplicationsCreatedOrModifiedLastWeekAsync();
            //ApplicationSamples.ViewDeletedApplicationsInLastWeekAsync();
            //JudgeSamples.AssignJudgeToApplicationAsync();
            //JudgeSamples.RemoveJudgeFromApplicationAsync();
            //JudgeSamples.AddJudgeToTeamAsync();
            //JudgeSamples.RemoveJudgeFromTeamAsync();
            //JudgeAssignmentSamples.GetAllJudgesOnTeamAsync();
            //JudgeAssignmentSamples.GetAllCurrentJudgeAssignmentsForApplicationsAsync();
            //EvaluationSample.GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdAsync();
            //EvaluationSample.UpdateEvaluationAsync();
            //SessionSamples.CreateSessionAsync();
            //SessionSamples.UpdateSessionFieldsAsync();
            //SessionSamples.DeleteSessionAsync();
            //SessionSamples.GetSessionsCreatedOrModifiedInLastWeekAsync();
            //SessionSamples.GetSessionDataByIdAsync();
            //SessionChairSamples.AddSessionChairToSessionAsync();
            //SessionChairSamples.RemoveSessionChairAsync();
        }
    }
}
