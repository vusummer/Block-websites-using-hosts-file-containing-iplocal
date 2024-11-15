using BLOCK_APP.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BLOCK_APP.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BlockApp;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

        public DbSet<BlockedWebsite> BlockedWebsites { get; set; }
    }
}
