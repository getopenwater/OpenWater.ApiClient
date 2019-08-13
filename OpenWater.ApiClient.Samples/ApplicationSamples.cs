using System;
using System.Collections.Generic;
using System.Linq;
using OpenWater.ApiClient.Application;
using OpenWater.ApiClient.FieldValues;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {
        public static void CreateNewApplicationExample()
        {
            var createRequest = new Application.CreateRequest(
                "Application 42", string.Empty,
                new List<FieldValueModelBase>(new[]
                {
                    new TextFieldValueModel("title", "Yet another application"),
                }), 23006, 8001
            );

            ApiClient.CreateApplicationAsync(createRequest).Wait();
        }

        public static PagingResponseApplicationListItemModel GetApplicationsCreatedInLast24HoursExample()
        {
            var oneDayAgo = DateTimeOffset.UtcNow.AddDays(-1);
            var applications = ApiClient.ApplicationListAsync(startedAtUtc: oneDayAgo).Result;

            return applications;
        }

        public static void UpdateApplicationData()
        {
            var applicationId = 18013;
            var submissionRequest = new SubmissionFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("title", "Updated Application")
            }, 14004);

            ApiClient.UpdateSubmissionFormAsync(applicationId, submissionRequest).Wait();
        }

        public static void UpdateApplicationCategoryExample()
        {
            int id = 18014;
            var categoryRequest = new ApplicationCategoryRequest("cat1_1_2");

            ApiClient.UpdateApplicationCategoryAsync(id, categoryRequest).Wait();
        }
    }
}
