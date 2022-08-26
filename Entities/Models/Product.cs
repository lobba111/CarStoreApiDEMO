using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        //fixa till så att den inte har en nyckel med sig från orderId
        public int Id { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public DateTime CarYear { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
