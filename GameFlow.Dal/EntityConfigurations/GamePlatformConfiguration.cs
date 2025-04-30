using GameFlow.Dal.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Dal.EntityConfigurations;

public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatform>
{
    public void Configure(EntityTypeBuilder<GamePlatform> builder)
    {
        builder.ToTable("GamePlatforms");

        builder.HasKey(gp => new { gp.GameId, gp.PlatformId });

        builder.HasOne(gp => gp.Game)
            .WithMany(g => g.GamePlatforms)
            .HasForeignKey(gp => gp.GameId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(gp => gp.Platform)
            .WithMany(g => g.GamePlatforms)
            .HasForeignKey(gp => gp.PlatformId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
