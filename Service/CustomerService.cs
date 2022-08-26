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
    internal sealed class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        public CustomerService(IRepositoryManager repository,IMapper mapper,ILoggerManager loggerManager)
        {
                _repository = repository;
                _mapper = mapper;
                _loggerManager = loggerManager;
        }

        public IEnumerable<CustomerDto> GetAllCustomers(bool trackChanges)
        {
            
            
                var customers = _repository.Customer.GetAllCostumers(trackChanges);
                var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
                return customersDto;
            
           
        }

        public CustomerDto GetCustomer(int id, bool trackChanges)
        {
            var customer = _repository.Customer.GetCustomer(id, trackChanges);
            if (customer is null)
            {
                throw new CustomerNotFoundException(id);
            }
            var customerDto = _mapper.Map<CustomerDto>(customer);  
            return customerDto;
        }
    }
}
