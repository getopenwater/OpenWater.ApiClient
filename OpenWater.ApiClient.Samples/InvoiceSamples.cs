using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenWater.ApiClient.Invoice;

namespace OpenWater.ApiClient.Samples
{
    public static class InvoiceSamples
    {
        private static OpenWaterApiClient ApiClient = Program.ApiClient;

        public static async Task<IEnumerable<InvoiceListItemModel>> GetAllInvoicesLastWeekAsync()
        {
            var invoices = (await ApiClient.GetInvoicesAsync()).Items.Where(i => i.CreatedAtUtc >= DateTime.UtcNow.AddDays(-7));

            return invoices;
        }

        public static async Task<DetailsResponse> GetInvoiceByIdAsync()
        {
            const int invoiceId = 1001;

            var invoice = ApiClient.GetInvoiceByIdAsync(invoiceId);

            return await invoice;
        }

        public static async Task<PagingResponseBillingLineItemListItemModel> GetAllBillingLineItemsSinceLastWeekAsync()
        {
            var lineItems = ApiClient.GetBillingLineItemsAsync(DateTime.UtcNow.Date.AddDays(-7));

            return await lineItems;
        }

        public static async Task<PagingResponsePaymentListItemModel> GetAllPaymentsSinceLastWeekAsync()
        {
            var payments = ApiClient.GetPaymentsAsync(DateTime.UtcNow.AddDays(-7));

            return await payments;
        }

        public static async Task<PagingResponseRefundListItemModel> GetAllRefundsSinceLastWeek()
        {
            var refunds = ApiClient.GetRefundsAsync(DateTimeOffset.UtcNow.AddDays(-7));

            return await refunds;
        }
    }
}
