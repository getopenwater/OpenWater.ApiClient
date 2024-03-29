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

namespace OpenWater.ApiClient.DeletedSession
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DeletedSessionListItemModel 
    {
        public DeletedSessionListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DeletedSessionListItemModel(System.DateTimeOffset deletedAtUtc, int id, int programId, int sessionId, string sessionName, int? deletedByUserId = null)
        {
              Id = @id;
              ProgramId = @programId;
              SessionId = @sessionId;
                  SessionName = @sessionName;
              DeletedByUserId = @deletedByUserId;
              DeletedAtUtc = @deletedAtUtc;
        }
    
        /// <summary>Deleted session id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>Solicitation id</summary>
        [Newtonsoft.Json.JsonProperty("programId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ProgramId { get; set; }
    
        /// <summary>Session id</summary>
        [Newtonsoft.Json.JsonProperty("sessionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SessionId { get; set; }
    
        /// <summary>Session type name</summary>
        [Newtonsoft.Json.JsonProperty("typeName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeName { get; set; }
    
        /// <summary>Session name</summary>
        [Newtonsoft.Json.JsonProperty("sessionName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SessionName { get; set; }
    
        /// <summary>Deleted by user id</summary>
        [Newtonsoft.Json.JsonProperty("deletedByUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DeletedByUserId { get; set; }
    
        /// <summary>Deleted since date (UTC)</summary>
        [Newtonsoft.Json.JsonProperty("deletedAtUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DeletedAtUtc { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108