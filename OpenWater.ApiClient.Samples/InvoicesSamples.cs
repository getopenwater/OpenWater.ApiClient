using System;
using System.Collections.Generic;
using System.Linq;
using OpenWater.ApiClient.Invoice;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {
        public static IEnumerable<Invoice.InvoiceListItemModel> GetAllInvoicesLastWeekExample()
        {
            var utcNow = DateTime.UtcNow;
            var weekStart = utcNow.AddDays(-7);
            var invoices = ApiClient.GetInvoicesAsync().Result.Items.Where(i => i.CreatedAtUtc >= weekStart);

            return invoices;
        }

        public static Invoice.DetailsResponse GetInvoiceByIdExample()
        {
            const int invoiceId = 1001;
            var invoice = ApiClient.GetInvoiceByIdAsync(invoiceId).Result;

            return invoice;
        }

        public static PagingResponseBillingLineItemListItemModel GetAllBillingLineItemsSinceLastWeekExample()
        {
            var lastWeekStart = DateTime.UtcNow.Date.AddDays(-7);
            var lineItems = ApiClient.GetBillingLineItemsAsync(lastModifiedUtc: lastWeekStart).Result;

            return lineItems;
        }

        public static PagingResponsePaymentListItemModel GetAllPaymentsSinceLastWeekExample()
        {
            var weekStart = DateTime.UtcNow.AddDays(-7);
            var payments = ApiClient.GetPaymentsAsync(lastModifiedUtc: weekStart).Result;

            return payments;
        }

        public static PagingResponseRefundListItemModel GetAllRefundsSinceLastWeekExample()
        {
            var lastWeekStart = DateTimeOffset.UtcNow.AddDays(-7);
            var refunds = ApiClient.GetRefundsAsync(lastModifiedUtc: lastWeekStart).Result;

            return refunds;
        }
    }
}
