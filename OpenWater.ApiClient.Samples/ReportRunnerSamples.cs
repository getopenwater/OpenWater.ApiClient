using System;
using System.Threading;
using System.Threading.Tasks;
using OpenWater.ApiClient.BackgroundJob;
using OpenWater.ApiClient.ReportRunner;
using DetailsResponseJobState = OpenWater.ApiClient.BackgroundJob.DetailsResponseJobState;

namespace OpenWater.ApiClient.Samples
{
    public static class ReportRunnerSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Run report background job and get result async
        /// </summary>
        public static async Task<DetailsResponse> RunReportBackgroundJobAsync()
        {
            const int reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = (await ApiClient.RunReportAsync(reportId, reportExportFormat)).JobId.Value;

            while (true)
            {
                var jobState = (await ApiClient.GetJobByIdAsync(jobId)).JobState;

                if (jobState == DetailsResponseJobState.Succeeded || jobState == DetailsResponseJobState.Failed)
                    return await ApiClient.GetJobByIdAsync(jobId);

                Thread.Sleep(millisecondsTimeout: 1000);
            }
        }

        /// <summary>
        /// Run report background job and get result async
        /// </summary>
        public static DetailsResponse RunReportBackgroundJob()
        {
            const int reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = ApiClient.RunReport(reportId, reportExportFormat).JobId.Value;

            while (true)
            {
                var jobState = ApiClient.GetJobById(jobId).JobState;

                if (jobState == DetailsResponseJobState.Succeeded || jobState == DetailsResponseJobState.Failed)
                    return ApiClient.GetJobById(jobId);

                Thread.Sleep(millisecondsTimeout: 1000);
            }
        }
    }
}