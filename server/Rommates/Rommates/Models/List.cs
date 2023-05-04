using Microsoft.EntityFrameworkCore;

namespace Roommates.Models
{
    public class List
    {
        public int Id { get; set; }
        public Item[] Items { get; set; }
    }


    public class ListContext : DbContext
    {
        public DbSet<List> Lists { get; set; }
        protected readonly IConfiguration Configuration;

        public ListContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

    }
}
