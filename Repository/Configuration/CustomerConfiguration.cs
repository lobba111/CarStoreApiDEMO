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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(SeedTestData());
        }

        public List<Customer> SeedTestData()
        {
            var cars = new List<Customer>();
            using (StreamReader r = new StreamReader(@"CustomerData.json"))
            {
                string json = r.ReadToEnd();
                cars = JsonConvert.DeserializeObject<List<Customer>>(json);
            }
           
            return cars;
        }
    }
}
