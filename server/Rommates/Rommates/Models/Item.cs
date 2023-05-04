using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Roommates.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        protected readonly IConfiguration Configuration;

        public ItemContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ItemContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer("Data Source=localhost;Initial Catalog=roommates;Integrated Security=true;TrustServerCertificate=True");
        }

    }


}