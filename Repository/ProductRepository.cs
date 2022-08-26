using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }

        public IEnumerable<Product> GetAllCarsOfMake(string make, bool trackChanges) =>    
            FindByCondition(x => x.CarMake.ToLower().Equals(make.ToLower()), trackChanges)
                .ToList();
        

        public IEnumerable<Product> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Id)
            .ToList();

        public Product GetProduct(int id, bool trackChanges) =>
            FindByCondition(x => x.Id.Equals(id),trackChanges)
            .SingleOrDefault();
        
           
        
    }
}
