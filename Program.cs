using LiskovSubstitutionExample.Invoices;

namespace LiskovSubstitutionExample
{
    class Program
    {
        static void Main(string[] args)
        {
               var invoiceManager = new InvoiceManager();
               invoiceManager.CreateInvoices();         
        }
    }
}
