using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenWater.ApiClient.Invoice;

namespace OpenWater.ApiClient.Samples
{
    public static class InvoiceSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Get invoices in last week async
        /// </summary>
        public static Task<PagingResponseInvoiceListItemModel> GetAllInvoicesLastWeekAsync()
        {
            return ApiClient.GetInvoicesAsync(mostRecentTransactionSinceUtc: DateTime.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get invoices in last week
        /// </summary>
        public static PagingResponseInvoiceListItemModel GetAllInvoicesLastWeek()
        {
            return ApiClient.GetInvoices(mostRecentTransactionSinceUtc: DateTime.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get invoice by id 1001 async
        /// </summary>
        public static Task<DetailsResponse> GetInvoiceByIdAsync()
        {
            const int invoiceId = 1001;

            return ApiClient.GetInvoiceByIdAsync(invoiceId);
        }

        /// <summary>
        /// Get invoice by id 1001
        /// </summary>
        public static DetailsResponse GetInvoiceById()
        {
            const int invoiceId = 1001;

            return ApiClient.GetInvoiceById(invoiceId);
        }

        /// <summary>
        /// Get all billing line items since last week async
        /// </summary>
        public static Task<PagingResponseBillingLineItemListItemModel> GetAllBillingLineItemsSinceLastWeekAsync()
        {
            return ApiClient.GetBillingLineItemsAsync(DateTime.UtcNow.Date.AddDays(-7));
        }

        /// <summary>
        /// Get all billing line items since last week
        /// </summary>
        public static PagingResponseBillingLineItemListItemModel GetAllBillingLineItemsSinceLastWeek()
        {
            return ApiClient.GetBillingLineItems(DateTime.UtcNow.Date.AddDays(-7));
        }

        /// <summary>
        /// Get all payments since last week async
        /// </summary>
        public static Task<PagingResponsePaymentListItemModel> GetAllPaymentsSinceLastWeekAsync()
        {
            return ApiClient.GetPaymentsAsync(DateTime.UtcNow.AddDays(-7));
        }


        /// <summary>
        /// Get all payments since last week
        /// </summary>
        public static PagingResponsePaymentListItemModel GetAllPaymentsSinceLastWeek()
        {
            return ApiClient.GetPayments(DateTime.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get all refunds since last week async
        /// </summary>
        public static Task<PagingResponseRefundListItemModel> GetAllRefundsSinceLastWeekAsync()
        {
            return ApiClient.GetRefundsAsync(DateTimeOffset.UtcNow.AddDays(-7));
        }

        /// <summary>
        /// Get all refunds since last week
        /// </summary>
        public static PagingResponseRefundListItemModel GetAllRefundsSinceLastWeek()
        {
            return ApiClient.GetRefunds(DateTimeOffset.UtcNow.AddDays(-7));
        }
    }
}