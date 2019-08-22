using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenWater.ApiClient.FieldValues;
using OpenWater.ApiClient.User;

namespace OpenWater.ApiClient.Samples
{
    public static class UserSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        public static Task CreateUserAsync()
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

            return ApiClient.CreateUserAsync(createRequest);
        }

        public static Task<DetailsResponse> CreateUserAndGetThatUserAsync()
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

            return ApiClient.CreateUserAsync(createRequest);
        }

        public static Task<PagingResponseUserListItemModel> GetAllUsersAsync()
        {
            return ApiClient.UserListAsync();
        }

        public static Task<PagingResponseUserListItemModel> GetUsersByNameAsync()
        {
            return ApiClient.UserListAsync(firstName: "Submitter");
        }

        public static Task<PagingResponseUserListItemModel> GetUsersWithPaginationAsync()
        {
            return ApiClient.UserListAsync(pageSize: 3, pageIndex: 1);
        }

        public static async Task CreateUserAndUpdateProfileAsync()
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

            var user = await ApiClient.CreateUserAsync(createRequest);

            if (user.Id != null)
            {
                var updateRequest = new ProfileFormValuesRequest(
                    new List<FieldValueModelBase>(new FieldValueModelBase[]
                    {
                        new TextFieldValueModel("companyName", "Yet Another Company Name"),
                    })
                );

                await ApiClient.UpdateProfileFormValuesAsync(user.Id.Value, updateRequest);
            }
        }

        public static Task UpdateProfileAsync()
        {
            const int userId = 8009;

            var profileRequest = new ProfileFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("firstName", "Yet Another Submitter")
            });

            return ApiClient.UpdateProfileFormValuesAsync(userId, profileRequest);
        }

        public static async Task<SsoTokenResponse> GetSsoUrlByUserEmailAsync()
        {
            const string email = "programbook@secure-platform.com";
            var ssoTokenRequest = new SsoTokenRequest("sample_url");

            var user = (await ApiClient.UserListAsync(email: email)).Items.First();

            return await ApiClient.GenerateSsoTokenAsync(user.Id.Value, ssoTokenRequest);
        }
    }
}
