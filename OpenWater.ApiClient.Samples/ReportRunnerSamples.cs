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

        public static async Task<DetailsResponse> RunReportBackgroundJobAsync()
        {
            const int reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = (await ApiClient.RunReportAsync(reportId, reportExportFormat)).JobId.Value;

            while (true)
            {
                var job = (await ApiClient.GetJobByIdAsync(jobId)).JobState;

                if (job == DetailsResponseJobState.Succeeded || job == DetailsResponseJobState.Failed)
                    return await ApiClient.GetJobByIdAsync(jobId);

                Thread.Sleep(millisecondsTimeout: 1000);
            }
        }
    }
}
