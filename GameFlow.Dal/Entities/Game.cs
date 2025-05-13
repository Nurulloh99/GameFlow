namespace GameFlow.Dal.Entities;

public class Game
{
    public Guid GameId { get; set; }
    public string GameName { get; set; }
    public string GameKey { get; set; } 
    public string? GameDescription { get; set; }
    public string FilePath { get; set; }
    public ICollection<GameGenre> GameGenres { get; set; }
    public ICollection<GamePlatform> GamePlatforms { get; set; }  
}
