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
        /// Create user async
        /// </summary>
        public static Task<DetailsResponse> CreateUserAsync()
        {
            var createRequest = new CreateRequest(
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
        /// Create user
        /// </summary>
        public static DetailsResponse CreateUser()
        {
            var createRequest = new CreateRequest(
                email: "jodoe8@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("Sample Company Name", "companyName")
                },
                firstName: "John",
                lastName: "Doe",
                password: "SecurePassword",
                thirdPartyUniqueId: "31122222"
            );

            return ApiClient.CreateUser(createRequest);
        }

        /// <summary>
        /// Get all users async
        /// </summary>
        public static Task<PagingResponseUserListItemModel> GetAllUsersAsync()
        {
            return ApiClient.GetUsersAsync();
        }

        /// <summary>
        /// Get all users
        /// </summary>
        public static PagingResponseUserListItemModel GetAllUsers()
        {
            return ApiClient.GetUsers();
        }

        /// <summary>
        /// Get users by name Submitter async
        /// </summary>
        public static Task<PagingResponseUserListItemModel> GetUsersByNameAsync()
        {
            return ApiClient.GetUsersAsync(firstName: "Submitter");
        }

        /// <summary>
        /// Get users by name Submitter
        /// </summary>
        public static PagingResponseUserListItemModel GetUsersByName()
        {
            return ApiClient.GetUsers(firstName: "Submitter");
        }

        /// <summary>
        /// Get users on page 1 when page size is 3 async
        /// </summary>
        public static Task<PagingResponseUserListItemModel> GetUsersWithPaginationAsync()
        {
            return ApiClient.GetUsersAsync(pageSize: 3, pageIndex: 1);
        }

        /// <summary>
        /// Get users on page 1 when page size is 3
        /// </summary>
        public static PagingResponseUserListItemModel GetUsersWithPagination()
        {
            return ApiClient.GetUsers(pageSize: 3, pageIndex: 1);
        }

        /// <summary>
        /// Create user and update profile async
        /// </summary>
        public static async Task CreateUserAndUpdateProfileAsync()
        {
            var createRequest = new CreateRequest(
                email: "jodoe2@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("Dohn","firstName"),
                    new TextFieldValueModel("Jonny", "lastName"),
                    new TextFieldValueModel("Sample Company Name", "companyName"),
                    new TextFieldValueModel("jodoeV@example.com", "emailAddress")
                },
                firstName: "Dohn",
                lastName: "Jonny",
                password: "SecurePassword",
                thirdPartyUniqueId: "123112"
            );

            var user = await ApiClient.CreateUserAsync(createRequest);

            var updateRequest = new UpdateUserProfileFormValuesRequest(
                new List<FieldValueModelBase>(new FieldValueModelBase[]
                {
                        new TextFieldValueModel("Yet Another Company Name", "companyName"),
                })
            );

            await ApiClient.UpdateUserProfileFormValuesAsync(user.Id, updateRequest);
        }

        /// <summary>
        /// Create user and update profile
        /// </summary>
        public static void CreateUserAndUpdateProfile()
        {
            var createRequest = new CreateRequest(
                email: "jodoe2@example.com",
                externalAccountData: "SampleData",
                fieldValues: new List<FieldValueModelBase>
                {
                    new TextFieldValueModel("Dohn", "firstName"),
                    new TextFieldValueModel("Jonny", "lastName"),
                    new TextFieldValueModel("Sample Company Name", "companyName"),
                    new TextFieldValueModel("jodoeV@example.com", "emailAddress"),
                },
                firstName: "Dohn",
                lastName: "Jonny",
                password: "SecurePassword",
                thirdPartyUniqueId: "123112"
            );

            var user = ApiClient.CreateUser(createRequest);

            var updateRequest = new UpdateUserProfileFormValuesRequest(
                new List<FieldValueModelBase>(new FieldValueModelBase[]
                {
                    new TextFieldValueModel("Yet Another Company Name", "companyName"),
                })
            );

            ApiClient.UpdateUserProfileFormValues(user.Id, updateRequest);
        }

        /// <summary>
        /// Update user profile by id 8009 and set first name "Yet Another Submitter" async
        /// </summary>
        public static Task UpdateProfileAsync()
        {
            const int userId = 8009;

            var profileRequest = new UpdateUserProfileFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("Yet Another Submitter", "firstName")
            });

            return ApiClient.UpdateUserProfileFormValuesAsync(userId, profileRequest);
        }

        /// <summary>
        /// Update user profile by id 8009 and set first name "Yet Another Submitter"
        /// </summary>
        public static void UpdateProfile()
        {
            const int userId = 8009;

            var profileRequest = new UpdateUserProfileFormValuesRequest(new List<FieldValueModelBase>
            {
                new TextFieldValueModel("Yet Another Submitter", "firstName")
            });

            ApiClient.UpdateUserProfileFormValues(userId, profileRequest);
        }

        /// <summary>
        /// Get SsoTokenRequest by user email "programbook@secure-platform.com" async
        /// </summary>
        public static async Task<GenerateUserSsoTokenResponse> GetSsoUrlByUserEmailAsync()
        {
            const string email = "programbook@secure-platform.com";
            var ssoTokenRequest = new GenerateUserSsoTokenRequest("sample_url");

            var user = (await ApiClient.GetUsersAsync(email: email)).Items.First();

            return await ApiClient.GenerateUserSsoTokenAsync(user.Id, ssoTokenRequest);
        }

        /// <summary>
        /// Get SsoTokenRequest by user email "programbook@secure-platform.com"
        /// </summary>
        public static GenerateUserSsoTokenResponse GetSsoUrlByUserEmail()
        {
            const string email = "programbook@secure-platform.com";
            var ssoTokenRequest = new GenerateUserSsoTokenRequest("sample_url");

            var user = ApiClient.GetUsers(email: email).Items.First();

            return ApiClient.GenerateUserSsoToken(user.Id, ssoTokenRequest);
        }
    }
}