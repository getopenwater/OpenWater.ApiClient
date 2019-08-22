using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenWater.ApiClient.JudgeAssignment;

namespace OpenWater.ApiClient.Samples
{
    public static class JudgeAssignmentSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        public static Task<PagingResponseJudgeListItemModel> GetAllCurrentJudgeAssignmentsForApplicationsAsync()
        {
            const int applicationId = 18022;
            const int roundId = 14010;

            return ApiClient.GetAssignedToApplicationAssignmentsAsync(applicationId, roundId);
        }

        public static Task<PagingResponseJudgeListItemModel> GetAllJudgesOnTeamAsync()
        {
            const int judgeTeamId = 3001;

            return ApiClient.GetAssignedToJudgeTeamAssignmentsAsync(judgeTeamId);
        }
    }
}
