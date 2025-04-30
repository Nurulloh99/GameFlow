using GameFlow.Dal.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Dal.EntityConfigurations;

public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
{
    public void Configure(EntityTypeBuilder<Platform> builder)
    {
        builder.ToTable("Platforms");

        builder.HasKey(p => p.PlatformId);

        builder.Property(p => p.PlatformType)
            .IsRequired()
            .HasMaxLength(100);
    }
}
