using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts(bool trackChanges);
        IEnumerable<ProductDto> GetAllCarsOfMake(string make, bool trackChanges);
        ProductDto GetProduct(int id,bool trackChanges);
    }
}
