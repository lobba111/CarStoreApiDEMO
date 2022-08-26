using ClientHttpService;
using Shared.DataTransferObjects;
using static ClientHttpService.IProductClientService;


async Task <IEnumerable<ProductDto>> GetAllProducts(IProductClientService productClientService)
{
    var products = await productClientService.GetAllProducts();
    foreach (var product in products)
    {
        Console.WriteLine(product.CarModel);
    }
    return products;
}
