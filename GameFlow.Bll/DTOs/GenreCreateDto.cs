using GameFlow.Dal.Entities;

namespace GameFlow.Bll.DTOs;

public class GenreCreateDto
{
    public string GenreName { get; set; }
    public Genre? ParentGenre { get; set; }
}
