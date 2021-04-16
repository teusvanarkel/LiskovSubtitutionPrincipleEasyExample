using LiskovSubstitutionExample.Services;
using Repositories;
using Services;

namespace LiskovSubstitutionExample.Invoices
{
    public class InvoiceManager
    {
        private IOrderRepository _orderRepository;
        private IInvoiceRepository _invoiceRepository;
        private IOrderService _orderService;
        private IInvoiceService _invoiceService;

        public InvoiceManager()
        {
            // for simplicity no dependency injection
            // so we create all the objects
            _orderRepository = new OrderRepository();
            _invoiceRepository = new InvoiceRepository();
            _orderService = new OrderService(_orderRepository);
            _invoiceService = new InvoiceService(_invoiceRepository);
        }
        public void CreateInvoices()
        {
            _orderService.CreateFakeOrders(_orderRepository);
            var invoicedOrders = _orderService.CreateInvoices();
            _invoiceService.Save(invoicedOrders);
        }
    }
}