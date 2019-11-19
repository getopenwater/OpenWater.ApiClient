using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenWater.ApiClient.Evaluation;

namespace OpenWater.ApiClient.Samples
{
    public static class EvaluationSample
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Get evaluation by application id 14003, judge email "judge1@nonprofitcms.org" and round id 14003 async
        /// </summary>
        public static async Task<EvaluationListItemModel> GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdAsync()
        {
            const int applicationId = 18003;
            const int roundId = 14001;
            const string judgeEmail = "judge1@nonprofitcms.org";

            return (await ApiClient.GetEvaluationsAsync(applicationId: applicationId, judgeEmail: judgeEmail, roundId: roundId)).Items.First();
        }

        /// <summary>
        /// Get evaluation by application id 14003, judge email "judge1@nonprofitcms.org" and round id 14003
        /// </summary>
        public static EvaluationListItemModel GetEvaluationByApplicationIdAndJudgeEmailAndRoundId()
        {
            const int applicationId = 18003;
            const int roundId = 14001;
            const string judgeEmail = "judge1@nonprofitcms.org";

            return ApiClient.GetEvaluations(applicationId: applicationId, judgeEmail: judgeEmail, roundId: roundId).Items.First();
        }

        /// <summary>
        /// Update evaluation by id 41014 and set scoring answer general score by alias "howWellDidThisApplicantPerform" text "The best!" async
        /// </summary>
        public static Task UpdateEvaluationAsync()
        {
            const int evaluationId = 41014;
            var formRequest = new UpdateEvaluationFormRequest(true,
                new List<GeneralScoringAnswerModel>
                {
                    new GeneralScoringAnswerModel("howWellDidThisApplicantPerform", text: "The best!")
                }, null);

            return ApiClient.UpdateEvaluationFormAsync(evaluationId, formRequest);
        }

        /// <summary>
        /// Update evaluation by id 41014 and set scoring answer general score by alias "howWellDidThisApplicantPerform" text "The best!"
        /// </summary>
        public static void UpdateEvaluation()
        {
            const int evaluationId = 41014;
            var formRequest = new UpdateEvaluationFormRequest(true, new List<GeneralScoringAnswerModel>
                {
                    new GeneralScoringAnswerModel("howWellDidThisApplicantPerform", text: "The best!")
                }, null);

            ApiClient.UpdateEvaluationForm(evaluationId, formRequest);
        }
    }
}