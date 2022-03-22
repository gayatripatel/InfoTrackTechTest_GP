using Microsoft.EntityFrameworkCore;
using WebScrapper.Data.Models;

namespace WebScrapper.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<SearchResults> SearchResults { get; set; }

        public virtual DbSet<SearchEngines> SearchEngines { get; set; }
    }
}
