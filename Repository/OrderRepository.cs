using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }

        public void CreateOrder(Order order) => Create(order);
        

        public IEnumerable<Order> GetAllOrders(int customerId,bool trackChanges) =>
            FindByCondition(x => x.Customer.Id.Equals(customerId),trackChanges)
            .OrderBy(y => y.Customer.UserName).ToList();

        public Order GetOrder(int id, bool trackChanges) =>
            FindByCondition(x => x.Id.Equals(id),trackChanges)
            .SingleOrDefault();
        public IEnumerable<Order> GetOrdersFilterdByMakeAndSales(bool trackChanges) =>
            FindAll(trackChanges)
            .ToList();
        
    }
}
