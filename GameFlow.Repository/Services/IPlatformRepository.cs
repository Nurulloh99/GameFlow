using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public interface IPlatformRepository
{
    Task InsertPlatformAsync(Platform platform);
    Task<Platform> SelectPlatformByIdAsync(Guid id);
    Task<ICollection<Platform>> SelectAllPlatformsAsync();
    Task<ICollection<Platform>> SelectPlatformsByGameKeyAsync(string key);
    Task UpdatePlatformAsync(Platform platform);
    Task DeletePlatformAsync(Guid id);
}