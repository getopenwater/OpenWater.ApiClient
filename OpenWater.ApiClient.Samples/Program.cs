using System;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {

        private static OpenWaterApiClient ApiClient;

        static void Main()
        {
            ApiClient = new OpenWaterApiClient("demo.secure-platform.com", "41c41e1c-9786-4f79-be44-8e14d4fdc95b");
            //ApiClient = new OpenWaterApiClient("localhost", "some api key", baseUrl: "http://localhost:11100");

            //GetAllUsersExample();
            //GetUsersByNameExample();
            //GetUsersWithPaginationExample();
            //CreateUserExample();
            //CreateUserAndGetThatUserExample();
            //CreateUserAndUpdateProfileExample();
            //UpdateProfileExample();
            //GetSsoUrlByUserEmailExample();
            //GetAllInvoicesLastWeekExample();
            //GetInvoiceByIdExample();
            //GetAllBillingLineItemsSinceLastWeekExample();
            //GetAllPaymentsSinceLastWeekExample();
            //GetAllRefundsSinceLastWeekExample();
            //RunReportBackgroundJobExample();
            //CreateNewApplicationExample();
            //GetApplicationsCreatedInLast24HoursExample();
            //UpdateApplicationDataExample();
            //UpdateApplicationCategoryExample();

            //UploadMediaViaUrlAndUpdateSubmissionMediaFieldExample();
            //Already exists: UpdateApplicationCategoryExample();
            //UpdateApplicationStatusFromPendingApprovalToComplete();
            //UpdateApplicationToAllowUserToMakeEditsExample();
            //AssignWinnerExample();
            //ForwardToNextRoundExample();
            //AddCollaboratorExample();
            //RemoveCollaboratorFromSubmissionExample();
            //ViewAllNewApplicationsCreatedOrModifiedLastWeekExample();
            //ViewDeletedApplicationsInLastWeekExample();
            //AssignJudgeToApplicationExample();
            //RemoveJudgeFromApplicationExample();
            //AddJudgeToTeamExample();
            //RemoveJudgeFromTeamExample();
            //GetAllJudgesOnTeamExample();
            //GetAllCurrentJudgeAssignmentsForApplications();
            //GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdExample();
            //UpdateEvaluationExample();
            //CreateSessionExample();
            //UpdateSessionFieldsExample();
            //DeleteSessionExample();
            //GetSessionsCreatedOrModifiedInLastWeekExample();
            //GetSessionDataByIdExample();
            //AddSessionChairToSessionExample();
            //RemoveSessionChairExample();
        }
    }
}
