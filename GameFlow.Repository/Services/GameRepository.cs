using System.Web.Mvc;
using GameFlow.Dal;
using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public class GameRepository(MainContext _mainContext) : IGameRepository
{

    public Task DeleteGameAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<FileContentResult> DownloadGameFileAsync(string key)
    {
        throw new NotImplementedException();
    }

    public async Task InsertGameAsync(Game game)
    {
        await _mainContext.AddAsync(game);
        await _mainContext.SaveChangesAsync();
    }

    public Task<ICollection<Game>> SelectAllGamesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Game> SelectGameByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Game> SelectGameByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Game>> SelectGamesByGenreIdAsync(Guid genreId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Game>> SelectGamesByPlatformIdAsync(Guid platformId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGameAsync(Game gameDto)
    {
        throw new NotImplementedException();
    }
}
