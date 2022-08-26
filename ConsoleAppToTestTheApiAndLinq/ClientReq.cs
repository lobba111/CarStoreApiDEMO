using ClientHttpService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppToTestTheApiAndLinq
{
    public class ClientReq
    {
        private readonly IProductClientService _product;
        public ClientReq(IProductClientService product) => _product = product;
        
    }
}
