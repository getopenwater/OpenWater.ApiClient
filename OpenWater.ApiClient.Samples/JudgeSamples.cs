using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWater.ApiClient.JudgeAssignment;

namespace OpenWater.ApiClient.Samples
{
    public static class JudgeSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task AssignJudgeToApplicationAsync()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            await ApiClient.AssignJudgeToApplicationAsync(new AssignJudgeToApplicationRequest(applicationId, userJudgeId, roundId));
        }

        public static async Task RemoveJudgeFromApplicationAsync()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            await ApiClient.UnassignJudgeFromApplicationAsync(userJudgeId, applicationId, roundId);
        }

        public static async Task AddJudgeToTeamAsync()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            await ApiClient.AssignJudgeToJudgeTeamAsync(new AssignJudgeToJudgeTeamRequest(judgeTeamId, judgeId));
        }

        public static async Task RemoveJudgeFromTeamAsync()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            await ApiClient.UnassignJudgeFromJudgeTeamAsync(judgeId, judgeTeamId);
        }
    }
}
