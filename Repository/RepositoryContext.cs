using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.Entity<Order>().HasKey(e => e.Id);
        }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}
