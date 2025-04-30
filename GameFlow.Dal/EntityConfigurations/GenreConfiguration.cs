using GameFlow.Dal.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Dal.EntityConfigurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable("Genres");

        builder.HasKey(g => g.GenreId);

        builder.Property(g => g.GenreName)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(g => g.ParentGenre)
          .WithMany(g => g.SubGenres)
          .HasForeignKey(g => g.ParentGenreId)
          .OnDelete(DeleteBehavior.Restrict);
    }
}
