using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Presentation.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _service;
        public ProductController(IServiceManager service) => _service = service;
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            
                var products = _service.ProductService.GetAllProducts(trackChanges: false);
                return Ok(products);            
        }
        [HttpGet("{make}")]
        public IActionResult GetCarsOfMake(string make)
        {
                var carsMake = _service.ProductService.GetAllCarsOfMake(make, trackChanges: false);
                return Ok(carsMake);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {
            var product = _service.ProductService.GetProduct(id, trackChanges: false);
            return Ok(product);
        }
            




    }
}
