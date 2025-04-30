using GameFlow.Dal.Entities;

namespace GameFlow.Bll.DTOs;

public class GameCreateDto
{
    public string GameName { get; set; }
    public string? GameDescription { get; set; }
    public string GameKey { get; set; }
        
    public ICollection<Guid> GameGenres { get; set; }
    public ICollection<Guid> GamePlatforms { get; set; }
}
