using GameFlow.Dal.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Dal.EntityConfigurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable("Games");

        builder.HasKey(g => g.GameId);

        builder.Property(g => g.GameName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(g => g.GameKey)
            .IsRequired(true)
            .HasMaxLength(100);

        builder.Property(g => g.GameDescription)
            .IsRequired(false)
            .HasMaxLength(500);


    }
}
