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

namespace OpenWater.ApiClient.Services
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AggregatedRowScore 
    {
        public AggregatedRowScore() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public AggregatedRowScore(ApplicationJudgementAggregatedScore score, int sortOrder)
        {
              SortOrder = @sortOrder;
              Score = @score;
        }
    
        [Newtonsoft.Json.JsonProperty("sortOrder", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SortOrder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ApplicationJudgementAggregatedScore Score { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationJudgementAggregatedScore 
    {
        public ApplicationJudgementAggregatedScore() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationJudgementAggregatedScore(double averageScore)
        {
              AverageScore = @averageScore;
        }
    
        [Newtonsoft.Json.JsonProperty("averageScore", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AverageScore { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class GeneralScoringQuestionAggregatedScore 
    {
        public GeneralScoringQuestionAggregatedScore() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public GeneralScoringQuestionAggregatedScore(int generalScoringQuestionId, ApplicationJudgementAggregatedScore score)
        {
              GeneralScoringQuestionId = @generalScoringQuestionId;
              Score = @score;
        }
    
        [Newtonsoft.Json.JsonProperty("generalScoringQuestionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int GeneralScoringQuestionId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ApplicationJudgementAggregatedScore Score { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SubmissionScoredFieldAggregatedScore 
    {
        public SubmissionScoredFieldAggregatedScore() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SubmissionScoredFieldAggregatedScore(System.Guid fieldId, System.Collections.Generic.ICollection<AggregatedRowScore> rowScores, ApplicationJudgementAggregatedScore score)
        {
              FieldId = @fieldId;
              Score = @score;
              RowScores = @rowScores;
        }
    
        [Newtonsoft.Json.JsonProperty("fieldId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid FieldId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ApplicationJudgementAggregatedScore Score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rowScores", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AggregatedRowScore> RowScores { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108