using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CarStore.Presentation.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceManager _service;
        public CustomerController(IServiceManager service) => _service = service;
        [HttpGet]
        public IActionResult GetCustomers()
        {            
                var customers = _service.CustomerService.GetAllCustomers(trackChanges: false);
                return Ok(customers);           
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _service.CustomerService.GetCustomer(id, trackChanges: false);
            return Ok(customer);
        }
        
    }
}
