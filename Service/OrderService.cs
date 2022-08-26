using AutoMapper;
using Contracts;
using Entities.Exeptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        public OrderService(IRepositoryManager repository,IMapper mapper,ILoggerManager loggerManager)
        {
            _repository = repository;
            _mapper = mapper;
            _loggerManager = loggerManager;
        }

        public OrderDto CreateOrder(OrderDto order)
        {
            
            //var mapProducts = _mapper.Map<List<Product>>(separator);
            //List<dynamic> products = new List<dynamic>();
            //products.AddRange(mapProducts);
            
            
            
            
            var orderEntity = _mapper.Map<Order>(order);
            _repository.Orders.CreateOrder(orderEntity);
           
            _repository.Save();
            
            return order;
        }

        public IEnumerable<OrderDto> GetAllOrders(int customerId,bool trackChanges)
        {            
                var orders = _repository.Orders.GetAllOrders(customerId,trackChanges);
                if (orders.Count() == 0)
                {
                    throw new OrderNotFoundException(customerId);
                }
                var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
                return ordersDto;
        }

        public OrderDto GetOrder(int id, bool trackChanges)
        {
            var order = _repository.Orders.GetOrder(id, trackChanges);
            if (order is null)
            {
                throw new OrderNotFoundException(id);
            }
            var orderDto = _mapper.Map<OrderDto>(order);
            return orderDto;
        }

        public IEnumerable<OrderDto> GetOrdersFilterdByMakeAndSales(bool trackChanges)
        {
            var order = _repository.Orders.GetOrdersFilterdByMakeAndSales(trackChanges);
            int id = 1;
            if (order.Count() == 0)
            {
                throw new OrderNotFoundException(id);

            }
            var orderDto = _mapper.Map<IEnumerable<OrderDto>>(order);
            return orderDto;
        }
    }
}
