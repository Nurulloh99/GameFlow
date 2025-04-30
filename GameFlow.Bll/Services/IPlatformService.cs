using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public interface IPlatformService
{
    Task AddPlatformAsync(PlatformCreateDto platformDto);
    Task<PlatformGetDto> GetPlatformByIdAsync(long id);
    Task<ICollection<PlatformGetDto>> GetAllPlatformsAsync();
    Task<ICollection<PlatformGetDto>> GetPlatformsByGameKeyAsync(string key);
    Task UpdatePlatformAsync(PlatformGetDto platformDto);
    Task DeletePlatformAsync(long id);
}
