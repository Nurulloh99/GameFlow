namespace GameFlow.Dal.Entities;

public class Platform
{
    public long PlatformId { get; set; }
    public string PlatformType { get; set; } = default!;

    public ICollection<GamePlatform> GamePlatforms { get; set; }
}
