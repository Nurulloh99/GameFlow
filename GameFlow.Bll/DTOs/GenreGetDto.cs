using GameFlow.Dal.Entities;

namespace GameFlow.Bll.DTOs;

public class GenreGetDto
{
    public Guid GenreId { get; set; }
    public string GenreName { get; set; }

    public Guid? ParentGenreId { get; set; }
    public Genre? ParentGenre { get; set; }

    public ICollection<Genre> SubGenres { get; set; }
    public ICollection<GameGenre> GameGenres { get; set; }
}
