using LiskovSubstitutionExample.Models;

namespace Repositories
{
    public interface IOrderRepository: IRepository<Order>
    { }
    public class OrderRepository: Repository<Order>, IOrderRepository{}
}