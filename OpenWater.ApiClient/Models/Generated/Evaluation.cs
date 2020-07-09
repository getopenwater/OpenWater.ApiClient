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

namespace OpenWater.ApiClient.Evaluation
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EvaluationListItemModel 
    {
        public EvaluationListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public EvaluationListItemModel(string applicationCode, int applicationId, System.DateTimeOffset evaluationDateUtc, int id, int judgeUserId, int programId, int roundId, System.DateTimeOffset startedAtUtc, JudgeScorecardStatus status, double totalScore, System.DateTimeOffset? updatedAtUtc = null)
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
    
        /// <summary>Evaluation id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>Program id</summary>
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; set; }
    
        /// <summary>Round id</summary>
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; set; }
    
        /// <summary>Judge user id</summary>
        [Newtonsoft.Json.JsonProperty("judgeUserId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int JudgeUserId { get; set; }
    
        /// <summary>Application id</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApplicationId { get; set; }
    
        /// <summary>Application code</summary>
        [Newtonsoft.Json.JsonProperty("applicationCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationCode { get; set; }
    
        /// <summary>Evaluation Status</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public JudgeScorecardStatus Status { get; set; }
    
        /// <summary>Evaluation total score</summary>
        [Newtonsoft.Json.JsonProperty("totalScore", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalScore { get; set; }
    
        /// <summary>Evaluation started date (UTC)</summary>
        [Newtonsoft.Json.JsonProperty("startedAtUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartedAtUtc { get; set; }
    
        /// <summary>Evaluation updated date (UTC)</summary>
        [Newtonsoft.Json.JsonProperty("updatedAtUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAtUtc { get; set; }
    
        /// <summary>Evaluation date (UTC)</summary>
        [Newtonsoft.Json.JsonProperty("evaluationDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EvaluationDateUtc { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        public DetailsResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(string applicationCode, int applicationId, double computedScore, System.DateTimeOffset evaluationDateUtc, System.Collections.Generic.ICollection<GeneralScoringAnswerModel> generalScoringAnswers, System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> inlineScoreFieldValues, System.Collections.Generic.ICollection<JudgeTeamInfo> judgeTeams, int judgeUserId, int programId, int roundId, int? rankPosition = null, int? rankScore = null)
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
    
        /// <summary>Program id</summary>
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; set; }
    
        /// <summary>Round id</summary>
        [Newtonsoft.Json.JsonProperty("roundId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundId { get; set; }
    
        /// <summary>Judge user id</summary>
        [Newtonsoft.Json.JsonProperty("judgeUserId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int JudgeUserId { get; set; }
    
        /// <summary>Application id</summary>
        [Newtonsoft.Json.JsonProperty("applicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApplicationId { get; set; }
    
        /// <summary>Application code</summary>
        [Newtonsoft.Json.JsonProperty("applicationCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicationCode { get; set; }
    
        /// <summary>Computed score</summary>
        [Newtonsoft.Json.JsonProperty("computedScore", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ComputedScore { get; set; }
    
        /// <summary>Rank score</summary>
        [Newtonsoft.Json.JsonProperty("rankScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankScore { get; set; }
    
        /// <summary>Rank position</summary>
        [Newtonsoft.Json.JsonProperty("rankPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankPosition { get; set; }
    
        /// <summary>Evaluation date (UTC)</summary>
        [Newtonsoft.Json.JsonProperty("evaluationDateUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EvaluationDateUtc { get; set; }
    
        /// <summary>Inline scores</summary>
        [Newtonsoft.Json.JsonProperty("inlineScoreFieldValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> InlineScoreFieldValues { get; set; }
    
        /// <summary>Evaluation form answers</summary>
        [Newtonsoft.Json.JsonProperty("generalScoringAnswers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GeneralScoringAnswerModel> GeneralScoringAnswers { get; set; }
    
        /// <summary>Judge teams</summary>
        [Newtonsoft.Json.JsonProperty("judgeTeams", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeTeamInfo> JudgeTeams { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeScoreFieldValueModel 
    {
        public JudgeScoreFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeScoreFieldValueModel(string alias, System.Collections.Generic.ICollection<RowJudgeScoreFieldValueModel> rowScores, double? score = null, string text = null)
        {
              Alias = @alias;
              RowScores = @rowScores;
              Score = @score;
              Text = @text;
        }
    
        /// <summary>Field alias</summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }
    
        /// <summary>Row scores</summary>
        [Newtonsoft.Json.JsonProperty("rowScores", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RowJudgeScoreFieldValueModel> RowScores { get; set; }
    
        /// <summary>Answer score</summary>
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; set; }
    
        /// <summary>Answer text</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class GeneralScoringAnswerModel 
    {
        public GeneralScoringAnswerModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public GeneralScoringAnswerModel(string alias, int? mediaId = null, double? score = null, string text = null)
        {
              Alias = @alias;
              MediaId = @mediaId;
              Score = @score;
              Text = @text;
        }
    
        /// <summary>Question alias</summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }
    
        /// <summary>Answer media id</summary>
        [Newtonsoft.Json.JsonProperty("mediaId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MediaId { get; set; }
    
        /// <summary>Answer Score</summary>
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; set; }
    
        /// <summary>Answer Text</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeTeamInfo 
    {
        public JudgeTeamInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeTeamInfo(int id, string name)
        {
              Id = @id;
              Name = @name;
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RowJudgeScoreFieldValueModel 
    {
        public RowJudgeScoreFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public RowJudgeScoreFieldValueModel(int rowId, double? score = null, string text = null)
        {
              RowId = @rowId;
              Score = @score;
              Text = @text;
        }
    
        /// <summary>Row id</summary>
        [Newtonsoft.Json.JsonProperty("rowId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RowId { get; set; }
    
        /// <summary>Answer score</summary>
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; set; }
    
        /// <summary>Answer text</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UpdateEvaluationFormRequest 
    {
        public UpdateEvaluationFormRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public UpdateEvaluationFormRequest(bool finalizeScore, System.Collections.Generic.ICollection<GeneralScoringAnswerModel> generalScoringAnswers, System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> inlineScoreFieldValues)
        {
              FinalizeScore = @finalizeScore;
              InlineScoreFieldValues = @inlineScoreFieldValues;
              GeneralScoringAnswers = @generalScoringAnswers;
        }
    
        /// <summary>Finalize evaluation</summary>
        [Newtonsoft.Json.JsonProperty("finalizeScore", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool FinalizeScore { get; set; }
    
        /// <summary>Inline scores</summary>
        [Newtonsoft.Json.JsonProperty("inlineScoreFieldValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeScoreFieldValueModel> InlineScoreFieldValues { get; set; }
    
        /// <summary>Evaluation form answers</summary>
        [Newtonsoft.Json.JsonProperty("generalScoringAnswers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GeneralScoringAnswerModel> GeneralScoringAnswers { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108