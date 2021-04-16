using System.Collections.Generic;
using LiskovSubstitutionExample.Enums;
using LiskovSubstitutionExample.Invoices;
using LiskovSubstitutionExample.Models;
using Repositories;

namespace LiskovSubstitutionExample.Services
{
    public class OrderService:IOrderService
    {
        IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Invoice> CreateInvoices()
        {
            var orders = _orderRepository.GetAll();
            var invoices = new List<Invoice>();

            var invoiceNumber = 0;
            foreach (var order in orders)
            {
                invoiceNumber ++;
                var invoice = InvoiceFactory.Create(order);
                var total = invoice.GetTotalAmount();
                invoice.Total = total;
                invoice.SetInvoiceNumber(invoiceNumber);
                invoices.Add(invoice);
            }
            return invoices;
        }

        public void CreateFakeOrders(IOrderRepository orderRepository)
        {
            orderRepository.Add(new Order()
            {
                Product = new Product() { Description = "milt", Price = 100 },
                Customer = new Customer() { Name = "Bad", TypeCustomer = CustomerType.bad },
                Amount = 10
            });
            orderRepository.Add(new Order()
            {
                Product = new Product() { Description = "milt", Price = 100 },
                Customer = new Customer() { Name = "Good", TypeCustomer = CustomerType.good },
                Amount = 10
            });
            orderRepository.Add(new Order()
            {
                Product = new Product() { Description = "milt", Price = 100 },
                Customer = new Customer() { Name = "Best", TypeCustomer = CustomerType.best },
                Amount = 10
            });
        }

    }
}