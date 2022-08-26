using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customer { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        void Save();
    }
}
