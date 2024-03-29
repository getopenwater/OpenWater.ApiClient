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

namespace OpenWater.ApiClient.ScheduleRoom
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateRequest 
    {
        public CreateRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateRequest(int capacity, string code, string name, string notes)
        {
              Name = @name;
              Code = @code;
              Capacity = @capacity;
              Notes = @notes;
        }
    
        /// <summary>Name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        public string Code { get; set; }
    
        /// <summary>Capacity</summary>
        [Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Always)]
        public int Capacity { get; set; }
    
        /// <summary>Notes</summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateResponse 
    {
        public CreateResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateResponse(int id)
        {
              Id = @id;
        }
    
        /// <summary>Schedule room id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ScheduleRoomListItemModel 
    {
        public ScheduleRoomListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ScheduleRoomListItemModel(string code, int id, string name, string notes, int? capacity = null)
        {
              Id = @id;
              Name = @name;
              Code = @code;
              Capacity = @capacity;
              Notes = @notes;
        }
    
        /// <summary>Schedule room Id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>Schedule room name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>Schedule room code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; }
    
        /// <summary>Schedule room capacity</summary>
        [Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Capacity { get; set; }
    
        /// <summary>Schedule room notes</summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UpdateRequest 
    {
        public UpdateRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public UpdateRequest(int capacity, string code, string name, string notes)
        {
              Name = @name;
              Code = @code;
              Capacity = @capacity;
              Notes = @notes;
        }
    
        /// <summary>Name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        public string Code { get; set; }
    
        /// <summary>Capacity</summary>
        [Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Always)]
        public int Capacity { get; set; }
    
        /// <summary>Notes</summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108