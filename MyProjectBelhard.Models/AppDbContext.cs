using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MyProjectBelhard.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DbConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
