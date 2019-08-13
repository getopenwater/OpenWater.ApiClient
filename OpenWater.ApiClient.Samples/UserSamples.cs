using System;
using System.Collections.Generic;
using System.Linq;
using OpenWater.ApiClient.FieldValues;
using OpenWater.ApiClient.User;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {
        public static void CreateUserExample()
        {
            var createRequest = new User.CreateRequest(
                email: "jodoe8@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("firstName", "John"),
                    new TextFieldValueModel("lastName", "Doe"),
                    new TextFieldValueModel("companyName", "Sample Company Name"),
                    new TextFieldValueModel("emailAddress", "jodoe8@example.com"),
                },
                firstName: "John",
                lastName: "Doe",
                password: "SecurePassword",
                thirdPartyUniqueId: "31122222"
            );

            ApiClient.CreateUserAsync(createRequest).Wait();
        }

        public static DetailsResponse CreateUserAndGetThatUserExample()
        {
            var createRequest = new User.CreateRequest(
                    email: "jodoe9@example.com",
                    externalAccountData: "SampleData",
                    fieldValues: new List<FieldValueModelBase>
                    {
                        new TextFieldValueModel("firstName", "Dohn"),
                        new TextFieldValueModel("lastName", "Joe"),
                        new TextFieldValueModel("companyName", "Sample Company Name"),
                        new TextFieldValueModel("emailAddress", "jodoe9@example.com"),
                    },
                    firstName: "Dohn",
                    lastName: "Joe",
                    password: "SecurePassword",
                    thirdPartyUniqueId: "311222"
                );

            return ApiClient.CreateUserAsync(createRequest).Result;
        }

        public static User.PagingResponseUserListItemModel GetAllUsersExample()
        {
            return ApiClient.UserListAsync().Result;
        }

        public static User.PagingResponseUserListItemModel GetUsersByName()
        {
            var name = "Submitter";

            return ApiClient.UserListAsync(name).Result;
        }

        public static User.PagingResponseUserListItemModel GetUsersWithPaginationExample()
        {
            var pageSize = 3;
            var pageIndex = 1;

            return ApiClient.UserListAsync(pageSize: pageSize, pageIndex: pageIndex).Result;
        }

        public static void CreateUserAndUpdateProfileExample()
        {
            var createRequest = new User.CreateRequest(
                email: "jodoe2@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("firstName", "Dohn"),
                    new TextFieldValueModel("lastName", "Jonny"),
                    new TextFieldValueModel("companyName", "Sample Company Name"),
                    new TextFieldValueModel("emailAddress", "jodoeV@example.com"),
                },
                firstName: "Dohn",
                lastName: "Jonny",
                password: "SecurePassword",
                thirdPartyUniqueId: "123112"
            );

            var user = ApiClient.CreateUserAsync(createRequest).Result;

            if (user.Id != null)
            {
                var updateRequest = new ProfileFormValuesRequest(
                    new List<FieldValueModelBase>(new FieldValueModelBase[]
                    {
                        new TextFieldValueModel("companyName", "Yet Another Company Name"),
                    })
                );

                ApiClient.UpdateProfileFormValuesAsync(user.Id.Value, updateRequest).Wait();
            }
        }

        public static void UpdateProfile()
        {
            var userId = 8009;
            var profileRequest = new ProfileFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("firstName", "Yet Another Submitter")
            });

            ApiClient.UpdateProfileFormValuesAsync(userId, profileRequest).Wait();
        }

        public static string GetSsoUrlByUserEmailExample()
        {
            var email = "programbook@secure-platform.com";
            var ssoTokenRequest = new SsoTokenRequest("sample_url");
            var user = ApiClient.UserListAsync(email: email).Result.Items.First();

            return ApiClient.GenerateSsoTokenAsync(user.Id.Value, ssoTokenRequest).Result.SingleSignOnUrl; 
        }
    }
}
