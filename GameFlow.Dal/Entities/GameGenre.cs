namespace GameFlow.Dal.Entities;

public class GameGenre
{
    public long GameId { get; set; }
    public Game Game { get; set; }

    public long GenreId { get; set; }
    public Genre Genre { get; set; }
}
