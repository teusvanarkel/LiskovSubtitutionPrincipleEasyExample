using LiskovSubstitutionExample.Invoices;

namespace Repositories
{
    public interface IInvoiceRepository: IRepository<Invoice>
    { }
    public class InvoiceRepository: Repository<Invoice>, IInvoiceRepository{}
}