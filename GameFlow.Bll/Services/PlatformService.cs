﻿using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public class PlatformService : IPlatformService
{
    public Task AddPlatformAsync(PlatformCreateDto platformDto)
    {
        throw new NotImplementedException();
    }

    public Task DeletePlatformAsync(Guid id)
    {
        throw new NotImplementedException();
    }
    
    public Task<ICollection<PlatformGetDto>> GetAllPlatformsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PlatformGetDto> GetPlatformByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<PlatformGetDto>> GetPlatformsByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePlatformAsync(PlatformGetDto platformDto)
    {
        throw new NotImplementedException();
    }
}
