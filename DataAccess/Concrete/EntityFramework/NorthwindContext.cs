using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //context: db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext //DbContext=> EntityFramework'ten gelir
    {
        //bu metot, projenin hangi veritabaniyla iliskili oldugunu belirtir
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-N08D4PD\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
        }
        //benim Product nesnemi veritabanındaki Products tablosu ile bağla
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
