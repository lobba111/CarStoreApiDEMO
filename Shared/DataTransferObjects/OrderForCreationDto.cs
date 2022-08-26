using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record OrderForCreationDto(int? Id,
    List<ProductDto> Products,
    decimal TotalPrice,
    int CustomerId,
    Customer? Customer);
    
    
}
