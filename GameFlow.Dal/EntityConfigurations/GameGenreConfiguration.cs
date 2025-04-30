using GameFlow.Dal.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Dal.EntityConfigurations;

public class GameGenreConfiguration : IEntityTypeConfiguration<GameGenre>
{
    public void Configure(EntityTypeBuilder<GameGenre> builder)
    {
        builder.ToTable("GameGenres");

        builder.HasKey(gg => new { gg.GameId, gg.GenreId });

        builder.HasOne(gg => gg.Game)
            .WithMany(g => g.GameGenres)
            .HasForeignKey(gg => gg.GameId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(gg => gg.Genre)
            .WithMany(g => g.GameGenres)
            .HasForeignKey(gg => gg.GenreId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
