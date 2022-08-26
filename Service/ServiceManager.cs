using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IOrderService> _orderService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper,ILoggerManager loggerManager)
        {
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager,mapper,loggerManager));
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager,mapper,loggerManager));
            _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager,mapper,loggerManager));
        }
        public ICustomerService CustomerService => _customerService.Value;
        public IProductService ProductService => _productService.Value;
        public IOrderService OrderService => _orderService.Value;
    }
}
