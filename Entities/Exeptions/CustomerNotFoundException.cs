using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exeptions
{
    public sealed class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(int id):base($"The customer with id: {id} dosent exist in the database.") { }
    }
}
