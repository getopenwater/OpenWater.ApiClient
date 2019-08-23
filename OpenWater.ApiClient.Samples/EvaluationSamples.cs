using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWater.ApiClient.JudgeScorecard;

namespace OpenWater.ApiClient.Samples
{
    public static class EvaluationSample
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        public static Task<PagingResponseJudgeScorecardListItemModel> GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdAsync()
        {
            const int applicationId = 18003;
            const string judgeEmail = "judge1@nonprofitcms.org";

            return ApiClient.JudgeScorecardListAsync(applicationId: applicationId, judgeEmail: judgeEmail);
        }

        public static PagingResponseJudgeScorecardListItemModel GetEvaluationByApplicationIdAndJudgeEmailAndRoundId()
        {
            const int applicationId = 18003;
            const string judgeEmail = "judge1@nonprofitcms.org";

            return ApiClient.JudgeScorecardList(applicationId: applicationId, judgeEmail: judgeEmail);
        }

        public static Task UpdateEvaluationAsync()
        {
            const int evaluationId = 41014;
            var formRequest = new EvaluationFormRequest(true,
                new List<GeneralScoringAnswerModel>
                {
                    new GeneralScoringAnswerModel("howWellDidThisApplicantPerform", null, null, "The best!")
                },
                null);

            return ApiClient.UpdateEvaluationFormAsync(evaluationId, formRequest);
        }

        public static void UpdateEvaluation()
        {
            const int evaluationId = 41014;
            var formRequest = new EvaluationFormRequest(true,
                new List<GeneralScoringAnswerModel>
                {
                    new GeneralScoringAnswerModel("howWellDidThisApplicantPerform", null, null, "The best!")
                },
                null);

            ApiClient.UpdateEvaluationForm(evaluationId, formRequest);
        }
    }
}
