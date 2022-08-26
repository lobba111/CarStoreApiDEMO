using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Presentation.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _service;
        public OrderController(IServiceManager service) => _service = service;
        
        [HttpGet]
        public IActionResult GetOrdersFilterdByMakeAndSales()
        {
            var orders = _service.OrderService.GetOrdersFilterdByMakeAndSales(trackChanges: false).ToList();
            var make = _service.ProductService.GetAllProducts(trackChanges: false).ToList();
            var map = orders.Select(o => new {Sales = o.Quantity,MakeId = o.Thing}).ToList();
            Dictionary<string, List<int>> map2 = new Dictionary<string, List<int>>();
            foreach (var item in make)
            {
                foreach (var item2 in map)
                {
                    if (item.Id == item2.MakeId)
                    {
                        if (!map2.ContainsKey(item.CarMake))
                        {
                            map2.Add(item.CarMake, new List<int>());
                            map2[item.CarMake].Add(item2.Sales);
                           
                        }
                        else if (map2.ContainsKey(item.CarMake))
                        {
                            map2[item.CarMake].Add(item2.Sales);
                        }
                    }
                }

                
            }
            Dictionary<string,double> result = new Dictionary<string,double>();
            foreach (var item in map2)
            {
                
                result.Add(item.Key, item.Value.Sum());
            }
            return Ok(result);
        }
        /*[HttpGet]
        public IActionResult GetAllOrders(int customerId)
        {
            
            
                var orders = _service.OrderService.GetAllOrders(customerId,trackChanges: false);
                return Ok(orders);
            
            
        }*/
        [HttpGet("{id:int}")]
        public IActionResult GetOrder(int id)
        {
            var order = _service.OrderService.GetOrder(id, trackChanges: false);
            return Ok(order);
        }
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderDto order)
        {
            if (order is null)
            {
                return BadRequest("OrderForCreation object is null.");
            }
            var createdOrder = _service.OrderService.CreateOrder(order);
            return NoContent();
        }
    }
}
