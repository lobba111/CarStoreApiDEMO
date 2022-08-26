using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        
        public int Thing { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
