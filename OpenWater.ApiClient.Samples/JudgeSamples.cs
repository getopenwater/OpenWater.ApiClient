using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenWater.ApiClient.JudgeAssignment;

namespace OpenWater.ApiClient.Samples
{
    public static partial class Program
    {
        public static void AssignJudgeToApplicationExample()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.AssignJudgeToApplicationAsync(new AssignJudgeToApplicationRequest(applicationId, userJudgeId, roundId)).Wait();
        }

        public static void RemoveJudgeFromApplicationExample()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.UnassignJudgeFromApplicationAsync(userJudgeId, applicationId, roundId).Wait();
        }
        
        public static void AddJudgeToTeamExample()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            ApiClient.AssignJudgeToJudgeTeamAsync(new AssignJudgeToJudgeTeamRequest(judgeTeamId, judgeId)).Wait();
        }

        public static void RemoveJudgeFromTeamExample()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            ApiClient.UnassignJudgeFromJudgeTeamAsync(judgeId, judgeTeamId).Wait();
        }
    }
}
