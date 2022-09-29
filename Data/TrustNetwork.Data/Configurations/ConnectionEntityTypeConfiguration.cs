using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustNetwork.Data.Models;

namespace TrustNetwork.Data.Configurations
{
    public class ConnectionEntityTypeConfiguration : IEntityTypeConfiguration<Connection>
    {
        public void Configure(EntityTypeBuilder<Connection> connection)
        {

        }
    }
}
