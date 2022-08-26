using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(SeedTestData());
        }

        public List<Product> SeedTestData()
        {
            var cars = new List<Product>();
            using (StreamReader r = new StreamReader(@"CarData.json"))
            {
                string json = r.ReadToEnd();
                cars = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            
            return cars;
        }
    }
}
