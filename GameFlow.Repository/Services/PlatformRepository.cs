using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public class PlatformRepository : IPlatformRepository
{
    public Task DeletePlatformAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task InsertPlatformAsync(Platform platform)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Platform>> SelectAllPlatformsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Platform> SelectPlatformByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Platform>> SelectPlatformsByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePlatformAsync(Platform platform)
    {
        throw new NotImplementedException();
    }
}
