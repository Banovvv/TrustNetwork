using Microsoft.EntityFrameworkCore;
using TrustNetwork.Data.Configurations;
using TrustNetwork.Data.Models;

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

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TrustConnection> TrustConnections { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PersonEntityTypeConfiguration().Configure(modelBuilder.Entity<Person>());
            new TopicEntityTypeConfiguration().Configure(modelBuilder.Entity<Topic>());
            new TrustConnectionEntityTypeConfiguration().Configure(modelBuilder.Entity<TrustConnection>());
            new MessageEntityTypeConfiguration().Configure(modelBuilder.Entity<Message>());
        }
    }
}