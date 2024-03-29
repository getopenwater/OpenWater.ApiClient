//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.1.2.0 (NJsonSchema v10.0.24.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

using OpenWater.ApiClient.Definitions;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace OpenWater.ApiClient.Application
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AllowUserToUpdateFinalizedRoundSubmissionRequest 
    {
        public AllowUserToUpdateFinalizedRoundSubmissionRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public AllowUserToUpdateFinalizedRoundSubmissionRequest(bool allowUserToMakeEdits, string reason)
        {
              AllowUserToMakeEdits = @allowUserToMakeEdits;
              Reason = @reason;
        }
    
        /// <summary>Allow user to edit a round submission</summary>
        [Newtonsoft.Json.JsonProperty("allowUserToMakeEdits", Required = Newtonsoft.Json.Required.Always)]
        public bool AllowUserToMakeEdits { get; set; }
    
        /// <summary>Reason to allow</summary>
        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationListItemModel 
    {
        public ApplicationListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationListItemModel(int id, System.DateTimeOffset lastModifiedUtc, int programId, int userId, string categoryFriendlyPath = null, string categoryName = null, string code = null, string name = null)
        {
              Id = @id;
              ProgramId = @programId;
              UserId = @userId;
              Code = @code;
              Name = @name;
              CategoryName = @categoryName;
              CategoryFriendlyPath = @categoryFriendlyPath;
              LastModifiedUtc = @lastModifiedUtc;
        }
    
        /// <summary>Application id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>Program id</summary>
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; set; }
    
        /// <summary>Application owner user Id</summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; set; }
    
        /// <summary>Application code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }
    
        /// <summary>Application name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>Application category name</summary>
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }
    
        /// <summary>Application category friendly path</summary>
        [Newtonsoft.Json.JsonProperty("categoryFriendlyPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryFriendlyPath { get; set; }
    
        /// <summary>Application last modified since date (UTC)</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset LastModifiedUtc { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ChangeFinalizedRoundSubmissionStatusRequest 
    {
        public ChangeFinalizedRoundSubmissionStatusRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ChangeFinalizedRoundSubmissionStatusRequest(SubmissionStatus status)
        {
              Status = @status;
        }
    
        /// <summary>Round submission status</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SubmissionStatus Status { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CollaboratorInfo 
    {
        public CollaboratorInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CollaboratorInfo(int id, int userId)
        {
              Id = @id;
              UserId = @userId;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateRequest 
    {
        public CreateRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateRequest(string applicationName, string categoryCode, System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> fieldValues, int programId, int userId)
        {
              ProgramId = @programId;
              UserId = @userId;
              ApplicationName = @applicationName;
              CategoryCode = @categoryCode;
              FieldValues = @fieldValues;
        }
    
        /// <summary>Program id</summary>
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Always)]
        public int ProgramId { get; set; }
    
        /// <summary>User id</summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Always)]
        public int UserId { get; set; }
    
        /// <summary>Application name</summary>
        [Newtonsoft.Json.JsonProperty("applicationName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationName { get; set; }
    
        /// <summary>Application category code</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }
    
        /// <summary>Round submission form values</summary>
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> FieldValues { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        public DetailsResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(System.Collections.Generic.ICollection<CollaboratorInfo> collaborators, string downloadPdfAsApplicantUrl, string downloadPdfAsJudgeUrl, string email, System.Collections.Generic.ICollection<int> fundTransactionIds, int id, int programId, string publicDownloadPdfAsApplicantUrl, System.Collections.Generic.ICollection<RoundSubmission> roundSubmissions, SchedulerInfo scheduler, int userId, string categoryCode = null, string categoryName = null, string categoryPath = null, string code = null, string externalAccountData = null, string name = null, int? sessionId = null, string thirdPartyUniqueId = null)
        {
              Id = @id;
              ProgramId = @programId;
              UserId = @userId;
              Email = @email;
              ThirdPartyUniqueId = @thirdPartyUniqueId;
              ExternalAccountData = @externalAccountData;
              SessionId = @sessionId;
              Name = @name;
              Code = @code;
              CategoryCode = @categoryCode;
              CategoryName = @categoryName;
              CategoryPath = @categoryPath;
              PublicDownloadPdfAsApplicantUrl = @publicDownloadPdfAsApplicantUrl;
              DownloadPdfAsApplicantUrl = @downloadPdfAsApplicantUrl;
              DownloadPdfAsJudgeUrl = @downloadPdfAsJudgeUrl;
              Scheduler = @scheduler;
              Collaborators = @collaborators;
              RoundSubmissions = @roundSubmissions;
              FundTransactionIds = @fundTransactionIds;
        }
    
        /// <summary>Application id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>Program id</summary>
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; set; }
    
        /// <summary>Application owner user Id</summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; set; }
    
        /// <summary>Application owner user Email</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }
    
        /// <summary>Application owner user 3rd party unique id</summary>
        [Newtonsoft.Json.JsonProperty("thirdPartyUniqueId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThirdPartyUniqueId { get; set; }
    
        /// <summary>Application owner user external auth data</summary>
        [Newtonsoft.Json.JsonProperty("externalAccountData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalAccountData { get; set; }
    
        /// <summary>Session id</summary>
        [Newtonsoft.Json.JsonProperty("sessionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SessionId { get; set; }
    
        /// <summary>Application name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>Application code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }
    
        /// <summary>Application category code</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }
    
        /// <summary>Application category name</summary>
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }
    
        /// <summary>Application category path</summary>
        [Newtonsoft.Json.JsonProperty("categoryPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryPath { get; set; }
    
        /// <summary>Public application as Applicant PDF url</summary>
        [Newtonsoft.Json.JsonProperty("publicDownloadPdfAsApplicantUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicDownloadPdfAsApplicantUrl { get; set; }
    
        /// <summary>Application as Applicant PDF url</summary>
        [Newtonsoft.Json.JsonProperty("downloadPdfAsApplicantUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DownloadPdfAsApplicantUrl { get; set; }
    
        /// <summary>Application as Judge PDF url</summary>
        [Newtonsoft.Json.JsonProperty("downloadPdfAsJudgeUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DownloadPdfAsJudgeUrl { get; set; }
    
        /// <summary>Application scheduler info</summary>
        [Newtonsoft.Json.JsonProperty("scheduler", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SchedulerInfo Scheduler { get; set; }
    
        /// <summary>Application collaborators</summary>
        [Newtonsoft.Json.JsonProperty("collaborators", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CollaboratorInfo> Collaborators { get; set; }
    
        /// <summary>Application round submissions</summary>
        [Newtonsoft.Json.JsonProperty("roundSubmissions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RoundSubmission> RoundSubmissions { get; set; }
    
        /// <summary>Application fund transaction ids</summary>
        [Newtonsoft.Json.JsonProperty("fundTransactionIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> FundTransactionIds { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeScorecardInfo 
    {
        public JudgeScorecardInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeScorecardInfo(int id, JudgeScorecardStatus status, double totalScore)
        {
              Id = @id;
              Status = @status;
              TotalScore = @totalScore;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public JudgeScorecardStatus Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("totalScore", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalScore { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RoundSubmission 
    {
        public RoundSubmission() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public RoundSubmission(string adminUrlToSubmission, bool isForwarded, bool isWinner, System.Collections.Generic.ICollection<JudgeScorecardInfo> judgeScorecardInfos, int numberOfAssignedJudges, int numberOfTimesJudged, string publicGalleryUrl, string publicUrlToSubmission, int roundId, string roundName, System.DateTimeOffset startedAtUtc, System.Collections.Generic.ICollection<string> winnerTypes, bool? allowUserToMakeEdits = null, double? averageScore = null, System.DateTimeOffset? finalizedAtUtc = null, System.Collections.Generic.ICollection<Services.GeneralScoringQuestionAggregatedScore> generalScoringQuestionsAggregatedScoreInfos = null, int? invoiceId = null, bool? isPaid = null, SubmissionStatus? status = null, System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> submissionFieldValues = null, System.Collections.Generic.ICollection<Services.SubmissionScoredFieldAggregatedScore> submissionScoredFieldsAggregatedScoreInfos = null, System.DateTimeOffset? updatedAtUtc = null, string winnerNotes = null)
        {
              RoundId = @roundId;
              RoundName = @roundName;
              StartedAtUtc = @startedAtUtc;
              UpdatedAtUtc = @updatedAtUtc;
              FinalizedAtUtc = @finalizedAtUtc;
              Status = @status;
              AllowUserToMakeEdits = @allowUserToMakeEdits;
              InvoiceId = @invoiceId;
              IsPaid = @isPaid;
              IsWinner = @isWinner;
              IsForwarded = @isForwarded;
              WinnerNotes = @winnerNotes;
              AdminUrlToSubmission = @adminUrlToSubmission;
              PublicUrlToSubmission = @publicUrlToSubmission;
              PublicGalleryUrl = @publicGalleryUrl;
              WinnerTypes = @winnerTypes;
              SubmissionFieldValues = @submissionFieldValues;
              JudgeScorecardInfos = @judgeScorecardInfos;
              NumberOfTimesJudged = @numberOfTimesJudged;
              NumberOfAssignedJudges = @numberOfAssignedJudges;
              AverageScore = @averageScore;
              SubmissionScoredFieldsAggregatedScoreInfos = @submissionScoredFieldsAggregatedScoreInfos;
              GeneralScoringQuestionsAggregatedScoreInfos = @generalScoringQuestionsAggregatedScoreInfos;
        }
    
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("roundName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoundName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("startedAtUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartedAtUtc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("updatedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAtUtc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("finalizedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FinalizedAtUtc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SubmissionStatus? Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowUserToMakeEdits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AllowUserToMakeEdits { get; set; }
    
        [Newtonsoft.Json.JsonProperty("invoiceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InvoiceId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("isPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("isWinner", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsWinner { get; set; }
    
        [Newtonsoft.Json.JsonProperty("isForwarded", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsForwarded { get; set; }
    
        [Newtonsoft.Json.JsonProperty("winnerNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WinnerNotes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("adminUrlToSubmission", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdminUrlToSubmission { get; set; }
    
        [Newtonsoft.Json.JsonProperty("publicUrlToSubmission", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicUrlToSubmission { get; set; }
    
        [Newtonsoft.Json.JsonProperty("publicGalleryUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicGalleryUrl { get; set; }
    
        [Newtonsoft.Json.JsonProperty("winnerTypes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> WinnerTypes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("submissionFieldValues", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> SubmissionFieldValues { get; set; }
    
        [Newtonsoft.Json.JsonProperty("judgeScorecardInfos", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScorecardInfo> JudgeScorecardInfos { get; set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfTimesJudged", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfTimesJudged { get; set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfAssignedJudges", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfAssignedJudges { get; set; }
    
        [Newtonsoft.Json.JsonProperty("averageScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AverageScore { get; set; }
    
        [Newtonsoft.Json.JsonProperty("submissionScoredFieldsAggregatedScoreInfos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Services.SubmissionScoredFieldAggregatedScore> SubmissionScoredFieldsAggregatedScoreInfos { get; set; }
    
        [Newtonsoft.Json.JsonProperty("generalScoringQuestionsAggregatedScoreInfos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Services.GeneralScoringQuestionAggregatedScore> GeneralScoringQuestionsAggregatedScoreInfos { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SchedulerInfo 
    {
        public SchedulerInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SchedulerInfo(System.DateTimeOffset applicationEndTimeUtc, System.DateTimeOffset applicationStartTimeUtc, int roomId, int timeSlotId)
        {
              ApplicationStartTimeUtc = @applicationStartTimeUtc;
              ApplicationEndTimeUtc = @applicationEndTimeUtc;
              RoomId = @roomId;
              TimeSlotId = @timeSlotId;
        }
    
        [Newtonsoft.Json.JsonProperty("applicationStartTimeUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ApplicationStartTimeUtc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("applicationEndTimeUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ApplicationEndTimeUtc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("roomId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoomId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("timeSlotId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TimeSlotId { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SetForwardingStatusForApplicationInRoundRequest 
    {
        public SetForwardingStatusForApplicationInRoundRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SetForwardingStatusForApplicationInRoundRequest(bool isForwarded)
        {
              IsForwarded = @isForwarded;
        }
    
        /// <summary>Is forwarded</summary>
        [Newtonsoft.Json.JsonProperty("isForwarded", Required = Newtonsoft.Json.Required.Always)]
        public bool IsForwarded { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SetWinnerStatusForApplicationInRoundRequest 
    {
        public SetWinnerStatusForApplicationInRoundRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SetWinnerStatusForApplicationInRoundRequest(bool isWinner, string winnerNotes, System.Collections.Generic.ICollection<int> winnerTypeIds, bool? replaceAlreadyAssignedWinnerTypes = null)
        {
              IsWinner = @isWinner;
              WinnerNotes = @winnerNotes;
              ReplaceAlreadyAssignedWinnerTypes = @replaceAlreadyAssignedWinnerTypes;
              WinnerTypeIds = @winnerTypeIds;
        }
    
        /// <summary>Is winner</summary>
        [Newtonsoft.Json.JsonProperty("isWinner", Required = Newtonsoft.Json.Required.Always)]
        public bool IsWinner { get; set; }
    
        /// <summary>Winner notes</summary>
        [Newtonsoft.Json.JsonProperty("winnerNotes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WinnerNotes { get; set; }
    
        /// <summary>Replace Existing Statuses before Setting. Set New Statuses but do not Clear Existing otherwise (if not set).</summary>
        [Newtonsoft.Json.JsonProperty("replaceAlreadyAssignedWinnerTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ReplaceAlreadyAssignedWinnerTypes { get; set; }
    
        /// <summary>Winner type ids</summary>
        [Newtonsoft.Json.JsonProperty("winnerTypeIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> WinnerTypeIds { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UpdateApplicationCategoryRequest 
    {
        public UpdateApplicationCategoryRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public UpdateApplicationCategoryRequest(string categoryCode)
        {
              CategoryCode = @categoryCode;
        }
    
        /// <summary>Category code</summary>
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.Always)]
        public string CategoryCode { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UpdateRoundSubmissionFormValuesRequest 
    {
        public UpdateRoundSubmissionFormValuesRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public UpdateRoundSubmissionFormValuesRequest(System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> fieldValues, int roundId)
        {
              RoundId = @roundId;
              FieldValues = @fieldValues;
        }
    
        /// <summary>Round id</summary>
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.Always)]
        public int RoundId { get; set; }
    
        /// <summary>Round submission form values</summary>
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> FieldValues { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108