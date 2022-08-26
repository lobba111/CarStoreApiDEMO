using Shared.DataTransferObjects;

namespace CarStoreBlazoeClient.Service.IHttpService
{
    public interface IOrderClientService
    {
        Task<OrderDto> CreateOrder(OrderDto order);
        Task<Dictionary<string, int>> GetSalesStatsPerMake();
    }
}
