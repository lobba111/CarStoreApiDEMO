using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exeptions
{
    public sealed class OrderNotFoundException : NotFoundException
    {
        public OrderNotFoundException(int id):base($"The order with id: {id}, dosent exist in the database.") { }
    }
}
