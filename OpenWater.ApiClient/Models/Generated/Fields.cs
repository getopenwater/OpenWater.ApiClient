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

namespace OpenWater.ApiClient.Fields
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AddressFieldModel : FieldModelBase
    {
        public AddressFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public AddressFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool isLine3Enabled, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              IsLine3Enabled = @isLine3Enabled;
        }
    
        [Newtonsoft.Json.JsonProperty("isLine3Enabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsLine3Enabled { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationCategoryFieldModel : FieldModelBase
    {
        public ApplicationCategoryFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationCategoryFieldModel(string alias, System.Collections.Generic.ICollection<SubmissionForm.Category> categories, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              Categories = @categories;
        }
    
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SubmissionForm.Category> Categories { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ApplicationNameFieldModel : FieldModelBase
    {
        public ApplicationNameFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public ApplicationNameFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool isOneTextField, bool required, TextLengthCountMode textLengthCountMode, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string firstTitle = null, int? maxLength = null, int? minLength = null, string name = null, string secondTitle = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              IsOneTextField = @isOneTextField;
              FirstTitle = @firstTitle;
              SecondTitle = @secondTitle;
              TextLengthCountMode = @textLengthCountMode;
              MinLength = @minLength;
              MaxLength = @maxLength;
        }
    
        [Newtonsoft.Json.JsonProperty("isOneTextField", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsOneTextField { get; set; }
    
        [Newtonsoft.Json.JsonProperty("firstTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstTitle { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secondTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondTitle { get; set; }
    
        [Newtonsoft.Json.JsonProperty("textLengthCountMode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TextLengthCountMode TextLengthCountMode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("minLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinLength { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CharityCheckFieldModel : FieldModelBase
    {
        public CharityCheckFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CharityCheckFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CheckboxListFieldModel : ListFieldModelBase
    {
        public CheckboxListFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CheckboxListFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, System.Collections.Generic.ICollection<Form.ListValue> listValues, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, int? maxSelectedValueCount = null, int? minSelectedValueCount = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, listValues, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              MinSelectedValueCount = @minSelectedValueCount;
              MaxSelectedValueCount = @maxSelectedValueCount;
        }
    
        [Newtonsoft.Json.JsonProperty("minSelectedValueCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinSelectedValueCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxSelectedValueCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxSelectedValueCount { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public abstract partial class ContainerFieldModelBase : FieldModelBase
    {
        public ContainerFieldModelBase() { }
    
        [Newtonsoft.Json.JsonConstructor]
        protected ContainerFieldModelBase(string alias, System.Collections.Generic.ICollection<FieldModelBase> fields, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              Fields = @fields;
        }
    
        [Newtonsoft.Json.JsonProperty("fields", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldModelBase> Fields { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DateFieldModel : FieldModelBase
    {
        public DateFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DateFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, System.DateTimeOffset? maxValueUtc = null, System.DateTimeOffset? minValueUtc = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              MinValueUtc = @minValueUtc;
              MaxValueUtc = @maxValueUtc;
        }
    
        [Newtonsoft.Json.JsonProperty("minValueUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? MinValueUtc { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxValueUtc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? MaxValueUtc { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DigitalSignatureFieldModel : FieldModelBase
    {
        public DigitalSignatureFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DigitalSignatureFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DropDownListFieldModel : ListFieldModelBase
    {
        public DropDownListFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DropDownListFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, System.Collections.Generic.ICollection<Form.ListValue> listValues, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, listValues, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EmailFieldModel : TextFieldModelBase
    {
        public EmailFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public EmailFieldModel(string alias, bool confirmationRequired, bool hidden, bool isDescriptionWysiwyg, bool required, FieldSize size, TextLengthCountMode textLengthCountMode, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, int? maxLength = null, int? minLength = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, size, textLengthCountMode, visibilityCondition, customCssClass, description, maxLength, minLength, name, sortOrder)
        {
              ConfirmationRequired = @confirmationRequired;
        }
    
        [Newtonsoft.Json.JsonProperty("confirmationRequired", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ConfirmationRequired { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public abstract partial class FieldModelBase 
    {
        public FieldModelBase() { }
    
        [Newtonsoft.Json.JsonConstructor]
        protected FieldModelBase(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
        {
              Alias = @alias;
              Name = @name;
              IsDescriptionWysiwyg = @isDescriptionWysiwyg;
              Description = @description;
              Hidden = @hidden;
              Required = @required;
              SortOrder = @sortOrder;
              CustomCssClass = @customCssClass;
              VisibilityCondition = @visibilityCondition;
            }
    
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("isDescriptionWysiwyg", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsDescriptionWysiwyg { get; set; }
    
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hidden", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Hidden { get; set; }
    
        [Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Required { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sortOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SortOrder { get; set; }
    
        [Newtonsoft.Json.JsonProperty("customCssClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomCssClass { get; set; }
    
        [Newtonsoft.Json.JsonProperty("visibilityCondition", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FieldVisibilityConditionModel VisibilityCondition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("typeName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeName { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FieldVisibilityConditionModel 
    {
        public FieldVisibilityConditionModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public FieldVisibilityConditionModel(string fieldAlias, System.Guid selectedListValueId)
        {
              FieldAlias = @fieldAlias;
              SelectedListValueId = @selectedListValueId;
        }
    
        [Newtonsoft.Json.JsonProperty("fieldAlias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FieldAlias { get; set; }
    
        [Newtonsoft.Json.JsonProperty("selectedListValueId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid SelectedListValueId { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FileUploadFieldModel : FieldModelBase
    {
        public FileUploadFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public FileUploadFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, bool showAudioPreview, bool showCaption, bool showDocumentPreview, bool showImagePreview, bool showVideoPreview, FieldVisibilityConditionModel visibilityCondition, string allowedFileExtensions = null, string captionLabel = null, string customCssClass = null, string description = null, int? maxFileSize = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              ShowCaption = @showCaption;
              ShowAudioPreview = @showAudioPreview;
              ShowImagePreview = @showImagePreview;
              ShowVideoPreview = @showVideoPreview;
              ShowDocumentPreview = @showDocumentPreview;
              MaxFileSize = @maxFileSize;
              AllowedFileExtensions = @allowedFileExtensions;
              CaptionLabel = @captionLabel;
        }
    
        [Newtonsoft.Json.JsonProperty("showCaption", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ShowCaption { get; set; }
    
        [Newtonsoft.Json.JsonProperty("showAudioPreview", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ShowAudioPreview { get; set; }
    
        [Newtonsoft.Json.JsonProperty("showImagePreview", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ShowImagePreview { get; set; }
    
        [Newtonsoft.Json.JsonProperty("showVideoPreview", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ShowVideoPreview { get; set; }
    
        [Newtonsoft.Json.JsonProperty("showDocumentPreview", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ShowDocumentPreview { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxFileSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxFileSize { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowedFileExtensions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AllowedFileExtensions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("captionLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CaptionLabel { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class LetterOfRecommendationFieldModel : ContainerFieldModelBase
    {
        public LetterOfRecommendationFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public LetterOfRecommendationFieldModel(string alias, bool allowReceiveRecommendationAfterSubmissionPeriodEnds, bool allowSubmitterToDeleteRecommendationOnIncompleteSubmission, bool allowSubmitterToViewCompletedRecommendation, bool allowToSendRequestPriorToFinalization, System.Collections.Generic.ICollection<FieldModelBase> fields, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string confirmationPageHtml = null, string customCssClass = null, string description = null, string instructionsHtml = null, string name = null, int? sortOrder = null)
            : base(alias, fields, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              AllowToSendRequestPriorToFinalization = @allowToSendRequestPriorToFinalization;
              AllowSubmitterToViewCompletedRecommendation = @allowSubmitterToViewCompletedRecommendation;
              AllowSubmitterToDeleteRecommendationOnIncompleteSubmission = @allowSubmitterToDeleteRecommendationOnIncompleteSubmission;
              AllowReceiveRecommendationAfterSubmissionPeriodEnds = @allowReceiveRecommendationAfterSubmissionPeriodEnds;
              InstructionsHtml = @instructionsHtml;
              ConfirmationPageHtml = @confirmationPageHtml;
        }
    
        [Newtonsoft.Json.JsonProperty("allowToSendRequestPriorToFinalization", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowToSendRequestPriorToFinalization { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowSubmitterToViewCompletedRecommendation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowSubmitterToViewCompletedRecommendation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowSubmitterToDeleteRecommendationOnIncompleteSubmission", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowSubmitterToDeleteRecommendationOnIncompleteSubmission { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowReceiveRecommendationAfterSubmissionPeriodEnds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowReceiveRecommendationAfterSubmissionPeriodEnds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("instructionsHtml", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstructionsHtml { get; set; }
    
        [Newtonsoft.Json.JsonProperty("confirmationPageHtml", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConfirmationPageHtml { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public abstract partial class ListFieldModelBase : FieldModelBase
    {
        public ListFieldModelBase() { }
    
        [Newtonsoft.Json.JsonConstructor]
        protected ListFieldModelBase(string alias, bool hidden, bool isDescriptionWysiwyg, System.Collections.Generic.ICollection<Form.ListValue> listValues, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              ListValues = @listValues;
        }
    
        [Newtonsoft.Json.JsonProperty("listValues", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Form.ListValue> ListValues { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MultilineTextFieldModel : TextFieldModelBase
    {
        public MultilineTextFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public MultilineTextFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool isWysiwyg, bool required, FieldSize size, TextLengthCountMode textLengthCountMode, FieldVisibilityConditionModel visibilityCondition, string allowedHtmlTags = null, string customCssClass = null, string description = null, int? maxLength = null, int? minLength = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, size, textLengthCountMode, visibilityCondition, customCssClass, description, maxLength, minLength, name, sortOrder)
        {
              IsWysiwyg = @isWysiwyg;
              AllowedHtmlTags = @allowedHtmlTags;
        }
    
        [Newtonsoft.Json.JsonProperty("isWysiwyg", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsWysiwyg { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowedHtmlTags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AllowedHtmlTags { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class NumberFieldModel : FieldModelBase
    {
        public NumberFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public NumberFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string format = null, int? maxPrecision = null, double? maxValue = null, double? minValue = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              MinValue = @minValue;
              MaxValue = @maxValue;
              MaxPrecision = @maxPrecision;
              Format = @format;
        }
    
        [Newtonsoft.Json.JsonProperty("minValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinValue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxPrecision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxPrecision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Format { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PhoneNumberFieldModel : FieldModelBase
    {
        public PhoneNumberFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PhoneNumberFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RadioListFieldModel : ListFieldModelBase
    {
        public RadioListFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public RadioListFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, System.Collections.Generic.ICollection<Form.ListValue> listValues, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, listValues, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SeparatorFieldModel : FieldModelBase
    {
        public SeparatorFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SeparatorFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SessionNameFieldModel : FieldModelBase
    {
        public SessionNameFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SessionNameFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SessionTypeFieldModel : FieldModelBase
    {
        public SessionTypeFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public SessionTypeFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TableFieldModel : ContainerFieldModelBase
    {
        public TableFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public TableFieldModel(string alias, System.Collections.Generic.ICollection<FieldModelBase> fields, bool hidden, bool isDescriptionWysiwyg, int maxRowCount, int minRowCount, bool required, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, string name = null, string rowName = null, string rowNamePlural = null, string rowTemplate = null, int? sortOrder = null)
            : base(alias, fields, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              RowName = @rowName;
              RowNamePlural = @rowNamePlural;
              RowTemplate = @rowTemplate;
              MinRowCount = @minRowCount;
              MaxRowCount = @maxRowCount;
        }
    
        [Newtonsoft.Json.JsonProperty("rowName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RowName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rowNamePlural", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RowNamePlural { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rowTemplate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RowTemplate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("minRowCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MinRowCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxRowCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MaxRowCount { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TextFieldModel : TextFieldModelBase
    {
        public TextFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public TextFieldModel(string alias, bool allowAutocompleteFromExternalSource, string externalAutocompleteSourceUrl, string externalValidationUrl, bool hidden, bool isDescriptionWysiwyg, bool required, FieldSize size, TextLengthCountMode textLengthCountMode, FieldVisibilityConditionModel visibilityCondition, bool? areOnlyExternalSourceValuesAllowed = null, string customCssClass = null, string description = null, int? maxLength = null, int? minLength = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, size, textLengthCountMode, visibilityCondition, customCssClass, description, maxLength, minLength, name, sortOrder)
        {
              ExternalValidationUrl = @externalValidationUrl;
              AllowAutocompleteFromExternalSource = @allowAutocompleteFromExternalSource;
              AreOnlyExternalSourceValuesAllowed = @areOnlyExternalSourceValuesAllowed;
              ExternalAutocompleteSourceUrl = @externalAutocompleteSourceUrl;
        }
    
        [Newtonsoft.Json.JsonProperty("externalValidationUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalValidationUrl { get; set; }
    
        [Newtonsoft.Json.JsonProperty("allowAutocompleteFromExternalSource", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AllowAutocompleteFromExternalSource { get; set; }
    
        [Newtonsoft.Json.JsonProperty("areOnlyExternalSourceValuesAllowed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AreOnlyExternalSourceValuesAllowed { get; set; }
    
        [Newtonsoft.Json.JsonProperty("externalAutocompleteSourceUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalAutocompleteSourceUrl { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public abstract partial class TextFieldModelBase : FieldModelBase
    {
        public TextFieldModelBase() { }
    
        [Newtonsoft.Json.JsonConstructor]
        protected TextFieldModelBase(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldSize size, TextLengthCountMode textLengthCountMode, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, int? maxLength = null, int? minLength = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, visibilityCondition, customCssClass, description, name, sortOrder)
        {
              TextLengthCountMode = @textLengthCountMode;
              MinLength = @minLength;
              MaxLength = @maxLength;
              Size = @size;
        }
    
        [Newtonsoft.Json.JsonProperty("textLengthCountMode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TextLengthCountMode TextLengthCountMode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("minLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinLength { get; set; }
    
        [Newtonsoft.Json.JsonProperty("maxLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }
    
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FieldSize Size { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UrlFieldModel : TextFieldModelBase
    {
        public UrlFieldModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public UrlFieldModel(string alias, bool hidden, bool isDescriptionWysiwyg, bool required, FieldSize size, TextLengthCountMode textLengthCountMode, FieldVisibilityConditionModel visibilityCondition, string customCssClass = null, string description = null, int? maxLength = null, int? minLength = null, string name = null, int? sortOrder = null)
            : base(alias, hidden, isDescriptionWysiwyg, required, size, textLengthCountMode, visibilityCondition, customCssClass, description, maxLength, minLength, name, sortOrder)
        {
        }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108