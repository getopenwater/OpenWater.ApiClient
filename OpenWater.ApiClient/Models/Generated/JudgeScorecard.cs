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

namespace OpenWater.ApiClient.JudgeScorecard
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseJudgeScorecardListItemModel 
    {
        internal PagingResponseJudgeScorecardListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseJudgeScorecardListItemModel(System.Collections.Generic.ICollection<JudgeScorecardListItemModel> items, Pagination.PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pagination.PagingInfo PagingInfo { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScorecardListItemModel> Items { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeScorecardListItemModel 
    {
        internal JudgeScorecardListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeScorecardListItemModel(string applicationCode, int applicationId, System.DateTimeOffset evaluationDateUtc, int id, int judgeUserId, int programId, int roundId, System.DateTimeOffset startedAtUtc, JudgeScorecardListItemModelStatus status, double totalScore, System.DateTimeOffset? updatedAtUtc)
        {
              Id = @id;
              ProgramId = @programId;
              RoundId = @roundId;
              JudgeUserId = @judgeUserId;
              ApplicationId = @applicationId;
              ApplicationCode = @applicationCode;
              Status = @status;
              TotalScore = @totalScore;
              StartedAtUtc = @startedAtUtc;
              UpdatedAtUtc = @updatedAtUtc;
              EvaluationDateUtc = @evaluationDateUtc;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("judgeUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int JudgeUserId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApplicationId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationCode { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public JudgeScorecardListItemModelStatus Status { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("totalScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalScore { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("startedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartedAtUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("updatedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAtUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("evaluationDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EvaluationDateUtc { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        internal DetailsResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(string applicationCode, int applicationId, double computedScore, System.DateTimeOffset evaluationDateUtc, System.Collections.Generic.ICollection<GeneralScoringAnswerModel> generalScoringAnswers, System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> inlineScoreFieldValues, System.Collections.Generic.ICollection<JudgeTeamInfo> judgeTeams, int judgeUserId, int programId, int? rankPosition, int? rankScore, int roundId)
        {
              ProgramId = @programId;
              RoundId = @roundId;
              JudgeUserId = @judgeUserId;
              ApplicationId = @applicationId;
              ApplicationCode = @applicationCode;
              ComputedScore = @computedScore;
              RankScore = @rankScore;
              RankPosition = @rankPosition;
              EvaluationDateUtc = @evaluationDateUtc;
              InlineScoreFieldValues = @inlineScoreFieldValues;
              GeneralScoringAnswers = @generalScoringAnswers;
              JudgeTeams = @judgeTeams;
        }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("judgeUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int JudgeUserId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApplicationId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationCode { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("computedScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ComputedScore { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("rankScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankScore { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("rankPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankPosition { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("evaluationDateUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EvaluationDateUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("inlineScoreFieldValues", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> InlineScoreFieldValues { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("generalScoringAnswers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GeneralScoringAnswerModel> GeneralScoringAnswers { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("judgeTeams", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeTeamInfo> JudgeTeams { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeScoreFieldValueModel 
    {
        internal JudgeScoreFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeScoreFieldValueModel(string alias, double? score, string text)
        {
              Alias = @alias;
              Score = @score;
              Text = @text;
        }
    
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class GeneralScoringAnswerModel 
    {
        internal GeneralScoringAnswerModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public GeneralScoringAnswerModel(string alias, int? mediaId, double? score, string text)
        {
              Alias = @alias;
              MediaId = @mediaId;
              Score = @score;
              Text = @text;
        }
    
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("mediaId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MediaId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeTeamInfo 
    {
        internal JudgeTeamInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeTeamInfo(int id, string name)
        {
              Id = @id;
              Name = @name;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EvaluationFormRequest 
    {
        internal EvaluationFormRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public EvaluationFormRequest(bool finalizeScore, System.Collections.Generic.ICollection<GeneralScoringAnswerModel> generalScoringAnswers, System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> inlineScoreFieldValues)
        {
              FinalizeScore = @finalizeScore;
              InlineScoreFieldValues = @inlineScoreFieldValues;
              GeneralScoringAnswers = @generalScoringAnswers;
        }
    
        [Newtonsoft.Json.JsonProperty("finalizeScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool FinalizeScore { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("inlineScoreFieldValues", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> InlineScoreFieldValues { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("generalScoringAnswers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GeneralScoringAnswerModel> GeneralScoringAnswers { get; internal set; }
    
    
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