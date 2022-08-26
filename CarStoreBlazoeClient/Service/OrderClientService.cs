using CarStoreBlazoeClient.Service.IHttpService;
using Shared.DataTransferObjects;
using System.Net.Http.Json;

namespace CarStoreBlazoeClient.Service
{
    public class OrderClientService : IOrderClientService
    {
        private readonly HttpClient _httpClient;
        public OrderClientService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<OrderDto> CreateOrder(OrderDto order)
        {
            var order1 = await _httpClient.PostAsJsonAsync("https://localhost:5002/api/orders", order);
            var response = await order1.Content.ReadFromJsonAsync<OrderDto>();
            return response;
        }

        public async Task<Dictionary<string, int>> GetSalesStatsPerMake()
        {
            var orders = await _httpClient.GetAsync("https://localhost:5002/api/orders");
            var response = await orders.Content.ReadFromJsonAsync<Dictionary<string, int>>();
            return response;
        }
    }
}
