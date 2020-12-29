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

namespace OpenWater.ApiClient.Media
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        public DetailsResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(string fileName, string url)
        {
              Url = @url;
              FileName = @fileName;
        }
    
        /// <summary>Media Url</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }
    
        /// <summary>Media file name</summary>
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateRequest 
    {
        public CreateRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateRequest(string fileName, string fileUrl)
        {
              FileUrl = @fileUrl;
              FileName = @fileName;
        }
    
        /// <summary>File url</summary>
        [Newtonsoft.Json.JsonProperty("fileUrl", Required = Newtonsoft.Json.Required.Always)]
        public string FileUrl { get; set; }
    
        /// <summary>File name</summary>
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateResponse 
    {
        public CreateResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateResponse(int mediaId, string url)
        {
              MediaId = @mediaId;
              Url = @url;
        }
    
        /// <summary>Media id</summary>
        [Newtonsoft.Json.JsonProperty("mediaId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MediaId { get; set; }
    
        /// <summary>Media Url</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108