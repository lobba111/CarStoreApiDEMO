using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
   public record ProductDto(
        int Id,
        string CarMake,
        string CarModel,
        DateTime CarYear,
        int Rating ,
        decimal Price,
        int Quantity);
}
