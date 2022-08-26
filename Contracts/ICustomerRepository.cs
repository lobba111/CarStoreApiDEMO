using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCostumers(bool trackChanges);
        Customer GetCustomer(int id,bool trackChanges);
    }
}
