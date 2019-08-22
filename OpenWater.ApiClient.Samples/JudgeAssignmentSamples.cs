using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenWater.ApiClient.JudgeAssignment;

namespace OpenWater.ApiClient.Samples
{
    public static class JudgeAssignmentSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task<PagingResponseJudgeListItemModel> GetAllCurrentJudgeAssignmentsForApplicationsAsync()
        {
            const int applicationId = 18022;
            const int roundId = 14010;

            var judgeAssignments = ApiClient.GetAssignedToApplicationAssignmentsAsync(applicationId, roundId);

            return await judgeAssignments;
        }

        public static async Task<PagingResponseJudgeListItemModel> GetAllJudgesOnTeamAsync()
        {
            const int judgeTeamId = 3001;

            var judgeTeamAssignments = ApiClient.GetAssignedToJudgeTeamAssignmentsAsync(judgeTeamId);

            return await judgeTeamAssignments;
        }
    }
}
