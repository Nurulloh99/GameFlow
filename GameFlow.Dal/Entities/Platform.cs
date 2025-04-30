namespace GameFlow.Dal.Entities;

public class Platform
{
    public Guid PlatformId { get; set; }
    public string PlatformType { get; set; }

    public ICollection<GamePlatform> GamePlatforms { get; set; }
}
