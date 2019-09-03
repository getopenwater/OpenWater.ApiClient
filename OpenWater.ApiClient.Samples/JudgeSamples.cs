﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWater.ApiClient.JudgeAssignment;

namespace OpenWater.ApiClient.Samples
{
    public static class JudgeSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Assign judge to application async
        /// </summary>
        public static Task AssignJudgeToApplicationAsync()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            return ApiClient.AssignJudgeToApplicationAsync(new AssignJudgeToApplicationRequest(applicationId, userJudgeId, roundId));
        }

        /// <summary>
        /// Assign judge to application
        /// </summary>
        public static void AssignJudgeToApplication()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.AssignJudgeToApplication(new AssignJudgeToApplicationRequest(applicationId, userJudgeId, roundId));
        }

        /// <summary>
        /// Remove judge from application async
        /// </summary>
        public static Task RemoveJudgeFromApplicationAsync()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            return ApiClient.UnassignJudgeFromApplicationAsync(userJudgeId, applicationId, roundId);
        }

        /// <summary>
        /// Remove judge from application
        /// </summary>
        public static void RemoveJudgeFromApplication()
        {
            const int userJudgeId = 8004;
            const int applicationId = 18015;
            const int roundId = 14004;

            ApiClient.UnassignJudgeFromApplication(userJudgeId, applicationId, roundId);
        }

        /// <summary>
        /// Add judge to team async
        /// </summary>
        public static Task AddJudgeToTeamAsync()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            return ApiClient.AssignJudgeToJudgeTeamAsync(new AssignJudgeToJudgeTeamRequest(judgeTeamId, judgeId));
        }

        /// <summary>
        /// Add judge to team
        /// </summary>
        public static void AddJudgeToTeam()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            ApiClient.AssignJudgeToJudgeTeam(new AssignJudgeToJudgeTeamRequest(judgeTeamId, judgeId));
        }

        /// <summary>
        /// Remove judge from team async
        /// </summary>
        public static Task RemoveJudgeFromTeamAsync()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            return ApiClient.UnassignJudgeFromJudgeTeamAsync(judgeId, judgeTeamId);
        }

        /// <summary>
        /// Remove judge from team
        /// </summary>
        public static void RemoveJudgeFromTeam()
        {
            const int judgeId = 8004;
            const int judgeTeamId = 30001;

            ApiClient.UnassignJudgeFromJudgeTeam(judgeId, judgeTeamId);
        }
    }
}