using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<IOrderRepository> _orderRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(repositoryContext));
        }
        public ICustomerRepository Customer => _customerRepository.Value;

        public IOrderRepository Orders => _orderRepository.Value;

        public IProductRepository Products => _productRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
        
    }
}
