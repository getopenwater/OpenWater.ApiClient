using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenWater.ApiClient.JudgeScorecard;

namespace OpenWater.ApiClient.Samples
{
    public static partial class Program
    {
        public static JudgeScorecardListItemModel GetEvaluationByApplicationIdAndJudgeEmailAndRoundIdExample()
        {
            const int applicationId = 18003;
            const string judgeEmail = "judge1@nonprofitcms.org";

            var judgeId = ApiClient.UserListAsync(email: judgeEmail, isJudge: true).Result.Items.First().Id;
            var evaluation = ApiClient.JudgeScorecardListAsync().Result.Items
                .First(j => j.ApplicationId == applicationId &&  j.JudgeUserId == judgeId);

            return evaluation;
        }

        public static void UpdateEvaluationExample()
        {
            const int evaluationId = 41014;

            var formRequest = new EvaluationFormRequest(true,
                new List<GeneralScoringAnswerModel>
                {
                    new GeneralScoringAnswerModel("howWellDidThisApplicantPerform", null, null, "The best!")
                },
                null);

            ApiClient.UpdateEvaluationFormAsync(evaluationId, formRequest).Wait();
        }
    }
}
