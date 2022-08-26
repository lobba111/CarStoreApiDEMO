using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders(int customerId,bool trackChanges);
        Order GetOrder(int customerId,bool trackChanges);
        IEnumerable<Order> GetOrdersFilterdByMakeAndSales(bool trackChanges);
        void CreateOrder(Order order);
    }
}
