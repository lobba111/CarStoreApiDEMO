using Microsoft.AspNetCore.Mvc;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClientHttpService
{
    public class ProductClientService : IProductClientService
    {
        private readonly HttpClient _httpClient;
        public ProductClientService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/products");
            return products;

        }
                
        
    }
}
