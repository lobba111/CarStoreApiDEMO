using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
                
        }

        public IEnumerable<Customer> GetAllCostumers(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Id)
            .ToList();
        public Customer GetCustomer(int id,bool trackChanges) =>
            FindByCondition(x => x.Id.Equals(id),trackChanges)
            .SingleOrDefault();
    }
}
