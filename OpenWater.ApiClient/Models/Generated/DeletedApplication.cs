//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.0.4.0 (NJsonSchema v10.0.21.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace OpenWater.ApiClient.DeletedApplication
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseDeletedApplicationListItem 
    {
        internal PagingResponseDeletedApplicationListItem() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseDeletedApplicationListItem(System.Collections.Generic.ICollection<DeletedApplicationListItem> items, Pagination.PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pagination.PagingInfo PagingInfo { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DeletedApplicationListItem> Items { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DeletedApplicationListItem 
    {
        internal DeletedApplicationListItem() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DeletedApplicationListItem(string applicationCode, string applicationName, System.DateTimeOffset deletedAtUtc, string email, string firstName, int id, string lastName, int programId, int userId)
        {
              Id = @id;
              ProgramId = @programId;
              ApplicationCode = @applicationCode;
              ApplicationName = @applicationName;
              UserId = @userId;
              Email = @email;
              FirstName = @firstName;
              LastName = @lastName;
              DeletedAtUtc = @deletedAtUtc;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationCode { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("deletedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DeletedAtUtc { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum RoundSubmissionStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotStarted")]
        NotStarted = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Incomplete")]
        Incomplete = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PendingApproval")]
        PendingApproval = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Disapproved")]
        Disapproved = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"InCart")]
        InCart = 5,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JudgeScorecardInfoStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotScored")]
        NotScored = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Started")]
        Started = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum RoundSubmissionStatusRequestStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotStarted")]
        NotStarted = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Incomplete")]
        Incomplete = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PendingApproval")]
        PendingApproval = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Disapproved")]
        Disapproved = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"InCart")]
        InCart = 5,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum DetailsResponseJobState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Undefined")]
        Undefined = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Uncommited")]
        Uncommited = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Awaiting")]
        Awaiting = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Scheduled")]
        Scheduled = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Enqueued")]
        Enqueued = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Processing")]
        Processing = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Succeeded")]
        Succeeded = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Deleted")]
        Deleted = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
        Failed = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum BillingLineItemModelTargetType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Coupon")]
        Coupon = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ApplicationJudgement")]
        ApplicationJudgement = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Submission")]
        Submission = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PaymentModelMethod
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Check")]
        Check = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OnSite")]
        OnSite = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CreditCard")]
        CreditCard = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PayPalExpress")]
        PayPalExpress = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TouchNet")]
        TouchNet = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChasePaymentech")]
        ChasePaymentech = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"StripeJs")]
        StripeJs = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"QuickPay")]
        QuickPay = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum BillingLineItemListItemModelTargetType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Coupon")]
        Coupon = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ApplicationJudgement")]
        ApplicationJudgement = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Submission")]
        Submission = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PaymentListItemModelMethod
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Check")]
        Check = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OnSite")]
        OnSite = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CreditCard")]
        CreditCard = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PayPalExpress")]
        PayPalExpress = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TouchNet")]
        TouchNet = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChasePaymentech")]
        ChasePaymentech = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"StripeJs")]
        StripeJs = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"QuickPay")]
        QuickPay = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JudgeScorecardListItemModelStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotScored")]
        NotScored = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Started")]
        Started = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ApplicationNameFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum DropDownListFieldModelPreFillType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UsStates")]
        UsStates = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CanadaProvinces")]
        CanadaProvinces = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Countries")]
        Countries = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UsStatesAndCanadaProvinces")]
        UsStatesAndCanadaProvinces = 4,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum EmailFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum EmailFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MultilineTextFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MultilineTextFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum TextFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum TextFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum UrlFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum UrlFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.4.0 (NJsonSchema v10.0.21.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class OpenWaterApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public OpenWaterApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.4.0 (NJsonSchema v10.0.21.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class OpenWaterApiException<TResult> : OpenWaterApiException
    {
        public TResult Result { get; private set; }

        public OpenWaterApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108