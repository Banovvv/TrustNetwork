using Microsoft.EntityFrameworkCore;

namespace TrustNetwork.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext()
        {
        }

        public ApplicationDataContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}