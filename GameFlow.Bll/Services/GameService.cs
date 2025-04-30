using System.Web.Mvc;
using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public class GameService : IGameService
{
    public Task AddGameAsync(GameCreateDto gameDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGameAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<FileContentResult> DownloadGameFileAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GameGetDto>> GetAllGamesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GameGetDto> GetGameByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<GameGetDto> GetGameByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GameGetDto>> GetGamesByGenreIdAsync(long genreId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GameGetDto>> GetGamesByPlatformIdAsync(long platformId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGameAsync(GameGetDto gameDto)
    {
        throw new NotImplementedException();
    }
}
