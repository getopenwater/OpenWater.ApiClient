using System;
using System.Threading.Tasks;
using OpenWater.ApiClient.ReportRunner;

namespace OpenWater.ApiClient.Samples
{
    public static class ReportRunnerSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task<string> RunReportBackgroundJobAsync()
        {
            const int reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = (await ApiClient.RunReportAsync(reportId, reportExportFormat)).JobId.Value;
            var job = (await ApiClient.GetJobByIdAsync(jobId)).ResultUrl;

            return job;
        }
    }
}
