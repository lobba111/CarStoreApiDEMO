using CarStoreBlazoeClient.Service.IHttpService;
using Shared.DataTransferObjects;
using System.Net.Http.Json;

namespace CarStoreBlazoeClient.Service
{
    public class ProductClientService : IProductClientService
    {
        private readonly HttpClient _httpClient;
        public ProductClientService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("https://localhost:5002/api/products");
            return products;

        }
    }
}
