using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EFcodeFirstFluentAPI;

namespace EFcodeFirstFluentAPI
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string CreditCard { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    class Order
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public int Units { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }

    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Manufacturer Manofacturer { get; set; }
        
    }

    class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Municipality { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

public class DBEnterprise : DbContext
{
    public DbSet<Manufacturer> Manufacturer { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order> Buy { get; set; }
}
