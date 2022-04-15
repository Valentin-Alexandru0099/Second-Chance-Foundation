using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Articles> Articles { get; set; }
        public DbSet<Eveniments> Eveniments { get; set; }
        public DbSet<Organizations> Organizations { get; set; }
        public DbSet<User> User { get; set; }

    }
}