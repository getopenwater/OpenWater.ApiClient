using System;
using System.Collections.Generic;
using System.Linq;
using OpenWater.ApiClient.Invoice;

namespace OpenWater.ApiClient.Samples
{
    public partial class Program
    {
        public static IEnumerable<Invoice.InvoiceListItemModel> GetAllInvoicesLastWeek()
        {
            var utcNow = DateTime.UtcNow;
            var weekStart = utcNow.AddDays(-7);
            var invoices = ApiClient.GetInvoicesAsync().Result.Items.Where(x => x.CreatedAtUtc >= weekStart);

            return invoices;
        }

        public static Invoice.DetailsResponse GetInvoiceById()
        {
            var id = 1001;
            var invoice = ApiClient.GetInvoiceByIdAsync(id).Result;

            return invoice;
        }

        public static PagingResponseBillingLineItemListItemModel GetAllBillingLineItemsSinceLastWeek()
        {
            DateTime lastWeekStart = DateTime.UtcNow.Date.AddDays(-7);
            var lineItems = ApiClient.GetBillingLineItemsAsync(lastModifiedUtc: lastWeekStart).Result;

            return lineItems;
        }

        public static PagingResponsePaymentListItemModel GetAllPaymentsSinceLastWeek()
        {
            DateTime weekStart = DateTime.UtcNow.AddDays(-7);
            var payments = ApiClient.GetPaymentsAsync(lastModifiedUtc: weekStart).Result;

            return payments;
        }

        public static PagingResponseRefundListItemModel GetAllRefundsSinceLastWeek()
        {
            var lastWeekStart = DateTimeOffset.UtcNow.AddDays(-7);
            var refunds = ApiClient.GetRefundsAsync(lastModifiedUtc: lastWeekStart).Result;

            return refunds;
        }
    }
}
