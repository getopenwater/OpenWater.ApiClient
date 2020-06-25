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

namespace OpenWater.ApiClient.FieldValues
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public abstract partial class FieldValueModelBase 
    {
        public FieldValueModelBase() { }
    
        [Newtonsoft.Json.JsonConstructor]
        protected FieldValueModelBase(string alias)
        {
              Alias = @alias;
            }
    
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }
    
        [Newtonsoft.Json.JsonProperty("typeName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeName { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AddressFieldValueModel : FieldValueModelBase
    {
        public AddressFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public AddressFieldValueModel(string alias, string city = null, string countryCode = null, string line2 = null, string line3 = null, string state = null, string street = null, string zip = null)
            : base(alias)
        {
              CountryCode = @countryCode;
              City = @city;
              State = @state;
              Zip = @zip;
              Street = @street;
              Line2 = @line2;
              Line3 = @line3;
        }
    
        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }
    
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zip { get; set; }
    
        [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street { get; set; }
    
        [Newtonsoft.Json.JsonProperty("line2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line2 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("line3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line3 { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationCategoryFieldValueModel : FieldValueModelBase
    {
        public ApplicationCategoryFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationCategoryFieldValueModel(string alias, System.Collections.Generic.ICollection<int> selectedPath)
            : base(alias)
        {
              SelectedPath = @selectedPath;
        }
    
        [Newtonsoft.Json.JsonProperty("selectedPath", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> SelectedPath { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationNameFieldValueModel : FieldValueModelBase
    {
        public ApplicationNameFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationNameFieldValueModel(string alias, string firstValue = null, string secondValue = null)
            : base(alias)
        {
              FirstValue = @firstValue;
              SecondValue = @secondValue;
        }
    
        [Newtonsoft.Json.JsonProperty("firstValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstValue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secondValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondValue { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CheckboxListFieldValueModel : FieldValueModelBase
    {
        public CheckboxListFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CheckboxListFieldValueModel(string alias, System.Collections.Generic.ICollection<Form.ListValue> selectedValues)
            : base(alias)
        {
              SelectedValues = @selectedValues;
        }
    
        [Newtonsoft.Json.JsonProperty("selectedValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Form.ListValue> SelectedValues { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DateFieldValueModel : FieldValueModelBase
    {
        public DateFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DateFieldValueModel(string alias, System.DateTimeOffset? valueUtc = null)
            : base(alias)
        {
              ValueUtc = @valueUtc;
        }
    
        [Newtonsoft.Json.JsonProperty("valueUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ValueUtc { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DigitalSignatureFieldValueModel : FieldValueModelBase
    {
        public DigitalSignatureFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DigitalSignatureFieldValueModel(string alias, string value = null)
            : base(alias)
        {
              Value = @value;
        }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FileUploadFieldValueModel : FieldValueModelBase
    {
        public FileUploadFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public FileUploadFieldValueModel(string alias, string caption = null, int? mediaId = null)
            : base(alias)
        {
              MediaId = @mediaId;
              Caption = @caption;
        }
    
        [Newtonsoft.Json.JsonProperty("mediaId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MediaId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("caption", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Caption { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ImisNumberFieldValueModel : FieldValueModelBase
    {
        public ImisNumberFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ImisNumberFieldValueModel(string alias, string result = null, string value = null)
            : base(alias)
        {
              Value = @value;
              Result = @result;
        }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Result { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class LetterOfRecommendationFieldValueModel : FieldValueModelBase
    {
        public LetterOfRecommendationFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public LetterOfRecommendationFieldValueModel(string alias, System.Collections.Generic.ICollection<FieldValueModelBase> fieldValues, string email = null, string fullName = null, System.DateTimeOffset? receivedAt = null, System.DateTimeOffset? reminderEmailLastSentAt = null, System.Guid? sentHash = null)
            : base(alias)
        {
              FullName = @fullName;
              Email = @email;
              SentHash = @sentHash;
              ReminderEmailLastSentAt = @reminderEmailLastSentAt;
              ReceivedAt = @receivedAt;
              FieldValues = @fieldValues;
        }
    
        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sentHash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? SentHash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reminderEmailLastSentAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReminderEmailLastSentAt { get; set; }
    
        [Newtonsoft.Json.JsonProperty("receivedAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReceivedAt { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValueModelBase> FieldValues { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ListFieldValueModel : FieldValueModelBase
    {
        public ListFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ListFieldValueModel(string alias, Form.ListValue selectedValue)
            : base(alias)
        {
              SelectedValue = @selectedValue;
        }
    
        [Newtonsoft.Json.JsonProperty("selectedValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Form.ListValue SelectedValue { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class NumberFieldValueModel : FieldValueModelBase
    {
        public NumberFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public NumberFieldValueModel(string alias, double? value = null)
            : base(alias)
        {
              Value = @value;
        }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SessionNameFieldValueModel : FieldValueModelBase
    {
        public SessionNameFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SessionNameFieldValueModel(string alias, string value = null)
            : base(alias)
        {
              Value = @value;
        }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TableFieldValueModel : FieldValueModelBase
    {
        public TableFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public TableFieldValueModel(string alias, System.Collections.Generic.ICollection<RowModel> rows)
            : base(alias)
        {
              Rows = @rows;
        }
    
        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RowModel> Rows { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RowModel 
    {
        public RowModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public RowModel(System.Collections.Generic.ICollection<FieldValueModelBase> fieldValues, int sortOrder)
        {
              SortOrder = @sortOrder;
              FieldValues = @fieldValues;
        }
    
        [Newtonsoft.Json.JsonProperty("sortOrder", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SortOrder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fieldValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldValueModelBase> FieldValues { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TextFieldValueModel : FieldValueModelBase
    {
        public TextFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public TextFieldValueModel(string alias, string value = null)
            : base(alias)
        {
              Value = @value;
        }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class WysiwygFieldValueModel : FieldValueModelBase
    {
        public WysiwygFieldValueModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public WysiwygFieldValueModel(string alias, string value = null)
            : base(alias)
        {
              Value = @value;
        }
    
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108