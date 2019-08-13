using System;
using OpenWater.ApiClient.ReportRunner;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {
        public static string RunReportBackgroundJobExample()
        {
            var reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = ApiClient.RunReportAsync(reportId, reportExportFormat).Result.JobId.Value;
            var job = ApiClient.GetJobByIdAsync(jobId).Result;

            return job.ResultUrl;
        }
    }
}
