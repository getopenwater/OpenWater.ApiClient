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

        public static async Task<JudgeScorecardListItemModel> GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdAsync()
        {
            const int applicationId = 18003;
            const string judgeEmail = "judge1@nonprofitcms.org";

            var judgeId = (await ApiClient.UserListAsync(email: judgeEmail, isJudge: true)).Items.First().Id;
            var judgeScorecardList = await ApiClient.JudgeScorecardListAsync();

            return judgeScorecardList.Items.First(j => j.ApplicationId == applicationId && j.JudgeUserId == judgeId);
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
    }
}
