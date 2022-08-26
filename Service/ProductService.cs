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
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        public ProductService(IRepositoryManager repository,IMapper mapper,ILoggerManager loggerManager)
        {
            _repository = repository;
            _mapper = mapper;
            _loggerManager = loggerManager;
        }

        public IEnumerable<ProductDto> GetAllCarsOfMake(string make, bool trackChanges)
        {
                var carsMake = _repository.Products.GetAllCarsOfMake(make, trackChanges);
            if (carsMake.Count() == 0)
            {
                throw new ProductNotFoundException(make);
            }
                var carsMakeDto = _mapper.Map<IEnumerable<ProductDto>>(carsMake);
                return carsMakeDto;
            
            
        }

        public IEnumerable<ProductDto> GetAllProducts(bool trackChanges)
        {
            try
            {
                var products = _repository.Products.GetAllProducts(trackChanges);
                var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
                return productsDto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ProductDto GetProduct(int id, bool trackChanges)
        {
            var product = _repository.Products.GetProduct(id, trackChanges);
            if (product is null)
            {
                throw new ProductNotFoundException(id);
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }
    }
}
