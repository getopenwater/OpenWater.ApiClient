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

        /// <summary>
        /// Get all current judge assignments for applications by id 18022 and round id 14010 async
        /// </summary>
        public static Task<PagingResponseJudgeListItemModel> GetAllCurrentJudgeAssignmentsForApplicationsAsync()
        {
            const int applicationId = 18022;
            const int roundId = 14010;

            return ApiClient.GetAssignedToApplicationAssignmentsAsync(applicationId, roundId);
        }

        /// <summary>
        /// Get all current judge assignments for applications by id 18022 and round id 14010
        /// </summary>
        public static PagingResponseJudgeListItemModel GetAllCurrentJudgeAssignmentsForApplications()
        {
            const int applicationId = 18022;
            const int roundId = 14010;

            return ApiClient.GetAssignedToApplicationAssignments(applicationId, roundId);
        }

        /// <summary>
        /// Get all judges on team by id 3001 async
        /// </summary>
        public static Task<PagingResponseJudgeListItemModel> GetAllJudgesOnTeamAsync()
        {
            const int judgeTeamId = 3001;

            return ApiClient.GetAssignedToJudgeTeamAssignmentsAsync(judgeTeamId);
        }

        /// <summary>
        /// Get all judges on team by id 3001
        /// </summary>
        public static PagingResponseJudgeListItemModel GetAllJudgesOnTeam()
        {
            const int judgeTeamId = 3001;

            return ApiClient.GetAssignedToJudgeTeamAssignments(judgeTeamId);
        }
    }
}