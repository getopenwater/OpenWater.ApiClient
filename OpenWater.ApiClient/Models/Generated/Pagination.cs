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

namespace OpenWater.ApiClient.Pagination
{
    using System = global::System;
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseApplicationListItemModel 
    {
        public PagingResponseApplicationListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseApplicationListItemModel(System.Collections.Generic.ICollection<Application.ApplicationListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Application.ApplicationListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingInfo 
    {
        public PagingInfo() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingInfo(bool hasNextPage, bool hasPreviousPage, int numberOfPages, int pageIndex, int pageSize, int totalCount)
        {
              PageIndex = @pageIndex;
              PageSize = @pageSize;
              TotalCount = @totalCount;
              NumberOfPages = @numberOfPages;
              HasPreviousPage = @hasPreviousPage;
              HasNextPage = @hasNextPage;
        }
    
        [Newtonsoft.Json.JsonProperty("pageIndex", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PageIndex { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PageSize { get; set; }
    
        [Newtonsoft.Json.JsonProperty("totalCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TotalCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("numberOfPages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfPages { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hasPreviousPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasPreviousPage { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hasNextPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasNextPage { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseDeletedApplicationListItem 
    {
        public PagingResponseDeletedApplicationListItem() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseDeletedApplicationListItem(System.Collections.Generic.ICollection<DeletedApplication.DeletedApplicationListItem> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DeletedApplication.DeletedApplicationListItem> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseEvaluationListItemModel 
    {
        public PagingResponseEvaluationListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseEvaluationListItemModel(System.Collections.Generic.ICollection<Evaluation.EvaluationListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Evaluation.EvaluationListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseInvoiceListItemModel 
    {
        public PagingResponseInvoiceListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseInvoiceListItemModel(System.Collections.Generic.ICollection<Invoice.InvoiceListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Invoice.InvoiceListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseBillingLineItemListItemModel 
    {
        public PagingResponseBillingLineItemListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseBillingLineItemListItemModel(System.Collections.Generic.ICollection<Invoice.BillingLineItemListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Invoice.BillingLineItemListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponsePaymentListItemModel 
    {
        public PagingResponsePaymentListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponsePaymentListItemModel(System.Collections.Generic.ICollection<Invoice.PaymentListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Invoice.PaymentListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseRefundListItemModel 
    {
        public PagingResponseRefundListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseRefundListItemModel(System.Collections.Generic.ICollection<Invoice.RefundListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Invoice.RefundListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseJudgeListItemModel 
    {
        public PagingResponseJudgeListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseJudgeListItemModel(System.Collections.Generic.ICollection<JudgeAssignment.JudgeListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<JudgeAssignment.JudgeListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseProgramListItemModel 
    {
        public PagingResponseProgramListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseProgramListItemModel(System.Collections.Generic.ICollection<Program.ProgramListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Program.ProgramListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseSessionListItemModel 
    {
        public PagingResponseSessionListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseSessionListItemModel(System.Collections.Generic.ICollection<Session.SessionListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Session.SessionListItemModel> Items { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PagingResponseUserListItemModel 
    {
        public PagingResponseUserListItemModel() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public PagingResponseUserListItemModel(System.Collections.Generic.ICollection<User.UserListItemModel> items, PagingInfo pagingInfo)
        {
              PagingInfo = @pagingInfo;
              Items = @items;
        }
    
        [Newtonsoft.Json.JsonProperty("pagingInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<User.UserListItemModel> Items { get; set; }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108