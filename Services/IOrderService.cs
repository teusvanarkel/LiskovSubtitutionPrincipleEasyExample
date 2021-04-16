using System.Collections.Generic;
using LiskovSubstitutionExample.Invoices;
using Repositories;

namespace LiskovSubstitutionExample.Services
{
    public interface IOrderService: IService
    {
        void CreateFakeOrders(IOrderRepository orderRepository);

        List<Invoice> CreateInvoices();
    }
}