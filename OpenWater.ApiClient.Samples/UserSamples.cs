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

        /// <summary>
        /// Create user async.
        /// </summary>
        public static Task<DetailsResponse> CreateUserAsync()
        {
            var createRequest = new User.CreateRequest(
                email: "jodoe8@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("companyName", "Sample Company Name")
                },
                firstName: "John",
                lastName: "Doe",
                password: "SecurePassword",
                thirdPartyUniqueId: "31122222"
            );

            return ApiClient.CreateUserAsync(createRequest);
        }

        /// <summary>
        /// Create user.
        /// </summary>
        public static DetailsResponse CreateUser()
        {
            var createRequest = new User.CreateRequest(
                email: "jodoe8@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("companyName", "Sample Company Name")
                },
                firstName: "John",
                lastName: "Doe",
                password: "SecurePassword",
                thirdPartyUniqueId: "31122222"
            );

            return ApiClient.CreateUser(createRequest);
        }

        /// <summary>
        /// Get all users async.
        /// </summary>
        public static Task<PagingResponseUserListItemModel> GetAllUsersAsync()
        {
            return ApiClient.UserListAsync();
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        public static PagingResponseUserListItemModel GetAllUsers()
        {
            return ApiClient.UserList();
        }

        /// <summary>
        /// Get users by name Submitter async.
        /// </summary>
        public static Task<PagingResponseUserListItemModel> GetUsersByNameAsync()
        {
            return ApiClient.UserListAsync(firstName: "Submitter");
        }

        /// <summary>
        /// Get users by name Submitter.
        /// </summary>
        public static PagingResponseUserListItemModel GetUsersByName()
        {
            return ApiClient.UserList(firstName: "Submitter");
        }

        /// <summary>
        /// Get users on page 1 when page size is 3 async.
        /// </summary>
        public static Task<PagingResponseUserListItemModel> GetUsersWithPaginationAsync()
        {
            return ApiClient.UserListAsync(pageSize: 3, pageIndex: 1);
        }

        /// <summary>
        /// Get users on page 1 when page size is 3.
        /// </summary>
        public static PagingResponseUserListItemModel GetUsersWithPagination()
        {
            return ApiClient.UserList(pageSize: 3, pageIndex: 1);
        }

        /// <summary>
        /// Create user and update profile async.
        /// </summary>
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

            var updateRequest = new ProfileFormValuesRequest(
                new List<FieldValueModelBase>(new FieldValueModelBase[]
                {
                        new TextFieldValueModel("companyName", "Yet Another Company Name"),
                })
            );

            await ApiClient.UpdateProfileFormValuesAsync(user.Id, updateRequest);
        }

        /// <summary>
        /// Create user and update profile.
        /// </summary>
        public static void CreateUserAndUpdateProfile()
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

            var user = ApiClient.CreateUser(createRequest);

            var updateRequest = new ProfileFormValuesRequest(
                new List<FieldValueModelBase>(new FieldValueModelBase[]
                {
                    new TextFieldValueModel("companyName", "Yet Another Company Name"),
                })
            );

            ApiClient.UpdateProfileFormValues(user.Id, updateRequest);
        }

        /// <summary>
        /// Update profile form of user with id 8009: set first name to "Yet Another Submitter" async.
        /// </summary>
        public static Task UpdateProfileAsync()
        {
            const int userId = 8009;

            var profileRequest = new ProfileFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("firstName", "Yet Another Submitter")
            });

            return ApiClient.UpdateProfileFormValuesAsync(userId, profileRequest);
        }

        /// <summary>
        /// Update profile form of user with id 8009: set first name to "Yet Another Submitter".
        /// </summary>
        public static void UpdateProfile()
        {
            const int userId = 8009;

            var profileRequest = new ProfileFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("firstName", "Yet Another Submitter")
            });

            ApiClient.UpdateProfileFormValues(userId, profileRequest);
        }

        /// <summary>
        /// Get SsoTokenRequest for user with email "programbook@secure-platform.com" async.
        /// </summary>
        public static async Task<SsoTokenResponse> GetSsoUrlByUserEmailAsync()
        {
            const string email = "programbook@secure-platform.com";
            var ssoTokenRequest = new SsoTokenRequest("sample_url");

            var user = (await ApiClient.UserListAsync(email: email)).Items.First();

            return await ApiClient.GenerateSsoTokenAsync(user.Id, ssoTokenRequest);
        }

        /// <summary>
        /// Get SsoTokenRequest for user with email "programbook@secure-platform.com".
        /// </summary>
        public static SsoTokenResponse GetSsoUrlByUserEmail()
        {
            const string email = "programbook@secure-platform.com";
            var ssoTokenRequest = new SsoTokenRequest("sample_url");

            var user = ApiClient.UserList(email: email).Items.First();

            return ApiClient.GenerateSsoToken(user.Id, ssoTokenRequest);
        }
    }
}