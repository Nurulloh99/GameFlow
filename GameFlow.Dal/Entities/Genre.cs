namespace GameFlow.Dal.Entities;

public class Genre
{
    public long GenreId { get; set; }
    public string GenreName { get; set; } = default!;

    public long? ParentGenreId { get; set; }
    public Genre? ParentGenre { get; set; }

    public ICollection<Genre> SubGenres { get; set; }
    public ICollection<GameGenre> GameGenres { get; set; }
}
