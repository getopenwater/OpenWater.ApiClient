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

namespace OpenWater.ApiClient.Application
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseApplicationListItemModel 
    {
        internal PagingResponseApplicationListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseApplicationListItemModel(System.Collections.Generic.ICollection<ApplicationListItemModel> items, Pagination.PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pagination.PagingInfo PagingInfo { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ApplicationListItemModel> Items { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationListItemModel 
    {
        internal ApplicationListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationListItemModel(string categoryFriendlyPath, string categoryName, string code, int id, System.DateTimeOffset lastModifiedUtc, string name, int programId)
        {
              Id = @id;
              ProgramId = @programId;
              Code = @code;
              Name = @name;
              CategoryName = @categoryName;
              CategoryFriendlyPath = @categoryFriendlyPath;
              LastModifiedUtc = @lastModifiedUtc;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("categoryFriendlyPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryFriendlyPath { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("lastModifiedUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset LastModifiedUtc { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateRequest 
    {
        internal CreateRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateRequest(string applicationName, string categoryCode, System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> fieldValues, int programId, int userId)
        {
              ProgramId = @programId;
              UserId = @userId;
              ApplicationName = @applicationName;
              CategoryCode = @categoryCode;
              FieldValues = @fieldValues;
        }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> FieldValues { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        internal DetailsResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(string categoryCode, string categoryName, string categoryPath, string code, System.Collections.Generic.ICollection<CollaboratorInfo> collaborators, string downloadPdfAsApplicantUrl, string downloadPdfAsJudgeUrl, int id, string name, int programId, System.Collections.Generic.ICollection<RoundSubmission> roundSubmissions, SchedulerInfo scheduler, int? sessionId, int userId)
        {
              Id = @id;
              ProgramId = @programId;
              UserId = @userId;
              SessionId = @sessionId;
              Name = @name;
              Code = @code;
              CategoryCode = @categoryCode;
              CategoryName = @categoryName;
              CategoryPath = @categoryPath;
              DownloadPdfAsApplicantUrl = @downloadPdfAsApplicantUrl;
              DownloadPdfAsJudgeUrl = @downloadPdfAsJudgeUrl;
              Scheduler = @scheduler;
              Collaborators = @collaborators;
              RoundSubmissions = @roundSubmissions;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("sessionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SessionId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryCode { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("categoryName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("categoryPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryPath { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("downloadPdfAsApplicantUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DownloadPdfAsApplicantUrl { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("downloadPdfAsJudgeUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DownloadPdfAsJudgeUrl { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("scheduler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SchedulerInfo Scheduler { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("collaborators", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CollaboratorInfo> Collaborators { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("roundSubmissions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RoundSubmission> RoundSubmissions { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SchedulerInfo 
    {
        internal SchedulerInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SchedulerInfo(System.DateTimeOffset applicationEndTimeUtc, System.DateTimeOffset applicationStartTimeUtc, int roomId, int timeSlotId)
        {
              ApplicationStartTimeUtc = @applicationStartTimeUtc;
              ApplicationEndTimeUtc = @applicationEndTimeUtc;
              RoomId = @roomId;
              TimeSlotId = @timeSlotId;
        }
    
        [Newtonsoft.Json.JsonProperty("applicationStartTimeUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ApplicationStartTimeUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("applicationEndTimeUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ApplicationEndTimeUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("roomId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoomId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("timeSlotId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TimeSlotId { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CollaboratorInfo 
    {
        internal CollaboratorInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CollaboratorInfo(int id, int userId)
        {
              Id = @id;
              UserId = @userId;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RoundSubmission 
    {
        internal RoundSubmission() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public RoundSubmission(string adminUrlToSubmission, bool? allowUserToMakeEdits, double? averageScore, System.DateTimeOffset? finalizedAtUtc, bool isForwarded, bool? isPaid, bool isWinner, System.Collections.Generic.ICollection<JudgeScorecardInfo> judgeScorecardInfos, int numberOfAssignedJudges, int numberOfTimesJudged, string publicGalleryUrl, int roundId, string roundName, System.DateTimeOffset startedAtUtc, RoundSubmissionStatus? status, System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> submissionFieldValues, System.DateTimeOffset? updatedAtUtc, string winnerNotes, System.Collections.Generic.ICollection<string> winnerTypes)
        {
              RoundId = @roundId;
              RoundName = @roundName;
              StartedAtUtc = @startedAtUtc;
              UpdatedAtUtc = @updatedAtUtc;
              FinalizedAtUtc = @finalizedAtUtc;
              Status = @status;
              AllowUserToMakeEdits = @allowUserToMakeEdits;
              IsPaid = @isPaid;
              IsWinner = @isWinner;
              IsForwarded = @isForwarded;
              WinnerNotes = @winnerNotes;
              AdminUrlToSubmission = @adminUrlToSubmission;
              PublicGalleryUrl = @publicGalleryUrl;
              WinnerTypes = @winnerTypes;
              SubmissionFieldValues = @submissionFieldValues;
              JudgeScorecardInfos = @judgeScorecardInfos;
              NumberOfTimesJudged = @numberOfTimesJudged;
              NumberOfAssignedJudges = @numberOfAssignedJudges;
              AverageScore = @averageScore;
        }
    
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("roundName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoundName { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("startedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartedAtUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("updatedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAtUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("finalizedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FinalizedAtUtc { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoundSubmissionStatus? Status { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("allowUserToMakeEdits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AllowUserToMakeEdits { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("isPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPaid { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("isWinner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsWinner { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("isForwarded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsForwarded { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("winnerNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WinnerNotes { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("adminUrlToSubmission", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdminUrlToSubmission { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("publicGalleryUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicGalleryUrl { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("winnerTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> WinnerTypes { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("submissionFieldValues", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> SubmissionFieldValues { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("judgeScorecardInfos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScorecardInfo> JudgeScorecardInfos { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfTimesJudged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfTimesJudged { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfAssignedJudges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfAssignedJudges { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("averageScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AverageScore { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeScorecardInfo 
    {
        internal JudgeScorecardInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeScorecardInfo(int id, JudgeScorecardInfoStatus status, double totalScore)
        {
              Id = @id;
              Status = @status;
              TotalScore = @totalScore;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public JudgeScorecardInfoStatus Status { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("totalScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalScore { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationCategoryRequest 
    {
        internal ApplicationCategoryRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationCategoryRequest(string categoryCode)
        {
              CategoryCode = @categoryCode;
        }
    
        [Newtonsoft.Json.JsonProperty("categoryCode", Required = Newtonsoft.Json.Required.Always)]
        public string CategoryCode { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RoundSubmissionStatusRequest 
    {
        internal RoundSubmissionStatusRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public RoundSubmissionStatusRequest(RoundSubmissionStatusRequestStatus status)
        {
              Status = @status;
        }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoundSubmissionStatusRequestStatus Status { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AllowUserToMakeEditsRequest 
    {
        internal AllowUserToMakeEditsRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public AllowUserToMakeEditsRequest(bool allowUserToMakeEdits)
        {
              AllowUserToMakeEdits = @allowUserToMakeEdits;
        }
    
        [Newtonsoft.Json.JsonProperty("allowUserToMakeEdits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowUserToMakeEdits { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class WinnerAssignmentRequest 
    {
        internal WinnerAssignmentRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public WinnerAssignmentRequest(bool isWinner, string winnerNotes, System.Collections.Generic.ICollection<int> winnerTypeIds)
        {
              IsWinner = @isWinner;
              WinnerNotes = @winnerNotes;
              WinnerTypeIds = @winnerTypeIds;
        }
    
        [Newtonsoft.Json.JsonProperty("isWinner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsWinner { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("winnerNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WinnerNotes { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("winnerTypeIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> WinnerTypeIds { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ForwardingRequest 
    {
        internal ForwardingRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ForwardingRequest(bool isForwarded)
        {
              IsForwarded = @isForwarded;
        }
    
        [Newtonsoft.Json.JsonProperty("isForwarded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsForwarded { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SubmissionFormValuesRequest 
    {
        internal SubmissionFormValuesRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SubmissionFormValuesRequest(System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> fieldValues, int roundId)
        {
              RoundId = @roundId;
              FieldValues = @fieldValues;
        }
    
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<FieldValues.FieldValueModelBase> FieldValues { get; internal set; }
    
    
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