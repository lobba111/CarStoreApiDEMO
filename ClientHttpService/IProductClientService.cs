using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHttpService
{
    public interface IProductClientService
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
    }
}
