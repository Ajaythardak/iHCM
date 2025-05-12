using iHcm.Models;
using Microsoft.EntityFrameworkCore;

namespace iHcm.Data
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        {
        }
        public DbSet<People> People => Set<People>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>();
        }
    }
}
