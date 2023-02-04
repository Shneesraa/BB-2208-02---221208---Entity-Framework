using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFBasics.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFBasics
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }    

        public DbSet<Supplier> Suppliers { get; set; }  

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Customer> Customers { get; set; }  

        public DbSet<Employee> Employees { get; set; }  

        public DbSet<Order> Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent api
            // Entity Framework'te veri modelini yapılandırma sentaksı

            var entityBuilder = modelBuilder.Entity<OrderDetail>();
            entityBuilder.HasKey(od => new
            {
                od.OrderID,
                od.ProductID
            });
        }


        // burayı override yazıp on yazıp bu metotu açıyoruz. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseSqlServer("Server=.; Database=Northwind; Integrated Security=true;");
        }


    }
}
