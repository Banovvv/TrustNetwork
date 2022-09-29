using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustNetwork.Data.Models;

namespace TrustNetwork.Data.Configurations
{
    public class ConnectionEntityTypeConfiguration : IEntityTypeConfiguration<TrustConnection>
    {
        public void Configure(EntityTypeBuilder<TrustConnection> connection)
        {

        }
    }
}
