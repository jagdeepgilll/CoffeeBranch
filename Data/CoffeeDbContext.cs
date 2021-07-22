using CoffeeBranch.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBranch.Data
{
    public class CoffeeDbContext : DbContext
    {
        // Here we add in all the tables we are using. 
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Order { get; set; }
        // We need 2 constructors, one is empty, and the other injects in DbContextOptions
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options)
        : base(options)
        {
        }
        public CoffeeDbContext()
        {
        }
    }
}
