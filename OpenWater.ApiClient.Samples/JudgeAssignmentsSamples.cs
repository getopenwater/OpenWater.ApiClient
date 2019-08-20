using System;
using System.Collections.Generic;
using System.Text;
using OpenWater.ApiClient.JudgeAssignment;

namespace OpenWater.ApiClient.Samples
{
    public  static partial class Program
    {
        public static PagingResponseJudgeListItemModel GetAllCurrentJudgeAssignmentsForApplications()
        {
            const int applicationId = 18022;
            const int roundId = 14010;

            var judgeAssignments = ApiClient.GetAssignedToApplicationAssignmentsAsync(applicationId, roundId).Result;

            return judgeAssignments;
        }

        public static PagingResponseJudgeListItemModel GetAllJudgesOnTeam()
        {
            const int judgeTeamId = 3001;

            var judgeTeamAssignments = ApiClient.GetAssignedToJudgeTeamAssignmentsAsync(judgeTeamId).Result;

            return judgeTeamAssignments;
        }
    }
}
