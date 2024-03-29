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

namespace OpenWater.ApiClient.JudgeReport
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AutoscoringReportRequest 
    {
        public AutoscoringReportRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public AutoscoringReportRequest(ExportAutoscoringRuleResultDataOptions exportDataOption, string outputFormat)
        {
              OutputFormat = @outputFormat;
              ExportDataOption = @exportDataOption;
        }
    
        /// <summary>Report output format (csv, xlsx)</summary>
        [Newtonsoft.Json.JsonProperty("outputFormat", Required = Newtonsoft.Json.Required.Always)]
        public string OutputFormat { get; set; }
    
        /// <summary>Export Data Option</summary>
        [Newtonsoft.Json.JsonProperty("exportDataOption", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ExportAutoscoringRuleResultDataOptions ExportDataOption { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CannedReportRequest 
    {
        public CannedReportRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CannedReportRequest(ExportJudgeResponsesDataOptions exportDataOption, ExportJudgeResponsesOptions exportOption, ExportJudgeResponsesStatusOptions exportStatusOption, string outputFormat, int? categoryGroupId = null, int? categoryId = null)
        {
              OutputFormat = @outputFormat;
              CategoryId = @categoryId;
              CategoryGroupId = @categoryGroupId;
              ExportOption = @exportOption;
              ExportDataOption = @exportDataOption;
              ExportStatusOption = @exportStatusOption;
        }
    
        /// <summary>Report output format (csv, xlsx)</summary>
        [Newtonsoft.Json.JsonProperty("outputFormat", Required = Newtonsoft.Json.Required.Always)]
        public string OutputFormat { get; set; }
    
        /// <summary>Category Id</summary>
        [Newtonsoft.Json.JsonProperty("categoryId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }
    
        /// <summary>Category Group Id</summary>
        [Newtonsoft.Json.JsonProperty("categoryGroupId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryGroupId { get; set; }
    
        /// <summary>Export Option</summary>
        [Newtonsoft.Json.JsonProperty("exportOption", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ExportJudgeResponsesOptions ExportOption { get; set; }
    
        /// <summary>Export Data Option</summary>
        [Newtonsoft.Json.JsonProperty("exportDataOption", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ExportJudgeResponsesDataOptions ExportDataOption { get; set; }
    
        /// <summary>Export Status Option</summary>
        [Newtonsoft.Json.JsonProperty("exportStatusOption", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ExportJudgeResponsesStatusOptions ExportStatusOption { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeDataReportRequest 
    {
        public JudgeDataReportRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeDataReportRequest(bool exportPendingApprovalJudges, string outputFormat)
        {
              OutputFormat = @outputFormat;
              ExportPendingApprovalJudges = @exportPendingApprovalJudges;
        }
    
        /// <summary>Report output format (csv, xlsx)</summary>
        [Newtonsoft.Json.JsonProperty("outputFormat", Required = Newtonsoft.Json.Required.Always)]
        public string OutputFormat { get; set; }
    
        /// <summary>Export Pending Approval Judges</summary>
        [Newtonsoft.Json.JsonProperty("exportPendingApprovalJudges", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ExportPendingApprovalJudges { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeListReportRequest 
    {
        public JudgeListReportRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeListReportRequest(string outputFormat, int? judgeTeamId = null)
        {
              OutputFormat = @outputFormat;
              JudgeTeamId = @judgeTeamId;
        }
    
        /// <summary>Report output format (csv, xlsx)</summary>
        [Newtonsoft.Json.JsonProperty("outputFormat", Required = Newtonsoft.Json.Required.Always)]
        public string OutputFormat { get; set; }
    
        /// <summary>Judge Team Id</summary>
        [Newtonsoft.Json.JsonProperty("judgeTeamId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? JudgeTeamId { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeNotesReportRequest 
    {
        public JudgeNotesReportRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeNotesReportRequest(string outputFormat)
        {
              OutputFormat = @outputFormat;
        }
    
        /// <summary>Report output format (csv, xlsx)</summary>
        [Newtonsoft.Json.JsonProperty("outputFormat", Required = Newtonsoft.Json.Required.Always)]
        public string OutputFormat { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeRecusalsReportRequest 
    {
        public JudgeRecusalsReportRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeRecusalsReportRequest(string outputFormat)
        {
              OutputFormat = @outputFormat;
        }
    
        /// <summary>Report output format (csv, xlsx)</summary>
        [Newtonsoft.Json.JsonProperty("outputFormat", Required = Newtonsoft.Json.Required.Always)]
        public string OutputFormat { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class JudgeReportResponse 
    {
        public JudgeReportResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public JudgeReportResponse(long jobId)
        {
              JobId = @jobId;
        }
    
        /// <summary>Report job id</summary>
        [Newtonsoft.Json.JsonProperty("jobId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long JobId { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108