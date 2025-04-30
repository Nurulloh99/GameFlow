namespace GameFlow.Dal.Entities;

public class GamePlatform
{
    public long GameId { get; set; }
    public Game Game { get; set; }

    public long PlatformId { get; set; }
    public Platform Platform { get; set; }
}
