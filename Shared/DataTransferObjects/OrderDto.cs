using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record OrderDto(
    /*int? Id*/
    int Thing,
    int Quantity,
    decimal TotalPrice,
    int CustomerId
    /*Customer? Customer*/);
}
