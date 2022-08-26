using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IOrderService
    {
        IEnumerable<OrderDto> GetAllOrders(int customerId,bool trackChanges);
        IEnumerable<OrderDto> GetOrdersFilterdByMakeAndSales(bool trackChanges);
        OrderDto GetOrder(int id,bool trackChanges);
        OrderDto CreateOrder(OrderDto order);
    }
}
