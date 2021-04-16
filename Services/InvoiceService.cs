using System.Collections.Generic;
using LiskovSubstitutionExample.Invoices;
using Repositories;

namespace Services
{
    public interface IInvoiceService
    {
        void Save(IEnumerable<Invoice> invoices);
    }
    
    public class InvoiceService:IInvoiceService
    {
        IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public void Save(IEnumerable<Invoice> invoices)
        {
            foreach (var invoice in invoices)
            {
                _invoiceRepository.Add(invoice);
            } 
        }
    }
}