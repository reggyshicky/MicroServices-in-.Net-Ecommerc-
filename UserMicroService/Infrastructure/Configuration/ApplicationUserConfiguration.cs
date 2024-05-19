using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.StreetAddress).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.PostalCode).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.City).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.State).HasMaxLength(250).IsRequired(false);
        }
    }
}
