using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exeptions
{
    public sealed class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(int id):base($"The product with id: {id}, dosent exist in the database.") { }
        public ProductNotFoundException(string make) : base($"The product with make: {make}, dosent exist in the database.") { }
    }
}
