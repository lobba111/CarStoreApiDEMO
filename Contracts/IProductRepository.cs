using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        IEnumerable<Product> GetAllCarsOfMake(string make,bool trackChanges);
        Product GetProduct(int id, bool trackChanges);

    }
}
