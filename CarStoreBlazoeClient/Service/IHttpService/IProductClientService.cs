using Shared.DataTransferObjects;

namespace CarStoreBlazoeClient.Service.IHttpService
{
    public interface IProductClientService
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
    }
}
