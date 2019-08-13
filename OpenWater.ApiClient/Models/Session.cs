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

namespace OpenWater.ApiClient.Session
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseSessionListItemModel 
    {
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseSessionListItemModel(System.Collections.Generic.ICollection<SessionListItemModel> @items, Pagination.PagingInfo @pagingInfo)
        {
            this.PagingInfo = @pagingInfo;
            this.Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pagination.PagingInfo PagingInfo { get; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SessionListItemModel> Items { get; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SessionListItemModel 
    {
        [Newtonsoft.Json.JsonConstructor]
        public SessionListItemModel(int? @id, string @name, int? @programId, string @typeName)
        {
            this.Id = @id;
            this.ProgramId = @programId;
            this.Name = @name;
            this.TypeName = @typeName;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ProgramId { get; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; }
    
        [Newtonsoft.Json.JsonProperty("typeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeName { get; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateRequest 
    {
        [Newtonsoft.Json.JsonConstructor]
        public CreateRequest(System.Collections.Generic.ICollection<int> @chairUserIds, System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> @fieldValues, string @name, int? @programId, int? @typeId)
        {
            this.ProgramId = @programId;
            this.TypeId = @typeId;
            this.Name = @name;
            this.ChairUserIds = @chairUserIds;
            this.FieldValues = @fieldValues;
        }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ProgramId { get; }
    
        [Newtonsoft.Json.JsonProperty("typeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TypeId { get; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; }
    
        [Newtonsoft.Json.JsonProperty("chairUserIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> ChairUserIds { get; }
    
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> FieldValues { get; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(System.Collections.Generic.ICollection<SessionChairInfo> @chairs, System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> @fieldValues, int? @id, System.Collections.Generic.ICollection<SessionItemInfo> @items, string @name, int? @programId, int? @typeId, string @typeName)
        {
            this.Id = @id;
            this.ProgramId = @programId;
            this.TypeId = @typeId;
            this.TypeName = @typeName;
            this.Name = @name;
            this.Chairs = @chairs;
            this.Items = @items;
            this.FieldValues = @fieldValues;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ProgramId { get; }
    
        [Newtonsoft.Json.JsonProperty("typeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TypeId { get; }
    
        [Newtonsoft.Json.JsonProperty("typeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeName { get; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; }
    
        [Newtonsoft.Json.JsonProperty("chairs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SessionChairInfo> Chairs { get; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SessionItemInfo> Items { get; }
    
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> FieldValues { get; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SessionChairInfo 
    {
        [Newtonsoft.Json.JsonConstructor]
        public SessionChairInfo(string @email, int? @id, bool? @isPrimary)
        {
            this.Id = @id;
            this.Email = @email;
            this.IsPrimary = @isPrimary;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; }
    
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; }
    
        [Newtonsoft.Json.JsonProperty("isPrimary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPrimary { get; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SessionItemInfo 
    {
        [Newtonsoft.Json.JsonConstructor]
        public SessionItemInfo(int? @applicationId, string @customSessionItemTypeDescription, int? @customSessionItemTypeId, int? @durationInMinutes, int? @sortOrder)
        {
            this.ApplicationId = @applicationId;
            this.CustomSessionItemTypeId = @customSessionItemTypeId;
            this.CustomSessionItemTypeDescription = @customSessionItemTypeDescription;
            this.SortOrder = @sortOrder;
            this.DurationInMinutes = @durationInMinutes;
        }
    
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ApplicationId { get; }
    
        [Newtonsoft.Json.JsonProperty("customSessionItemTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CustomSessionItemTypeId { get; }
    
        [Newtonsoft.Json.JsonProperty("customSessionItemTypeDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomSessionItemTypeDescription { get; }
    
        [Newtonsoft.Json.JsonProperty("sortOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SortOrder { get; }
    
        [Newtonsoft.Json.JsonProperty("durationInMinutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DurationInMinutes { get; }
    
    
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