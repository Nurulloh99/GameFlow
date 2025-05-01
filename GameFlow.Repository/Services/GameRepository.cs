using System.Web.Mvc;
using GameFlow.Dal;
using GameFlow.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Repository.Services;

public class GameRepository : IGameRepository
{
    private readonly MainContext _mainContext;

    public GameRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

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

    public async Task<Game> SelectGameByKeyAsync(string key)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(nameof(key));
        var game =  _mainContext.Games;
        var gameByKey = await game.FirstOrDefaultAsync(x => x.GameKey == key);
        if (gameByKey == null)
            throw new ArgumentNullException(nameof(gameByKey));
        return gameByKey;
    }

    public Task<ICollection<Game>> SelectGamesByGenreIdAsync(Guid genreId)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<Game>> SelectGamesByPlatformIdAsync(Guid platformId)
    {
        var games = _mainContext.Games;
        var gamesByPlatformId = await games.Where(x => x.GamePlatforms.Any(y => y.PlatformId == platformId)).ToListAsync();
        if (gamesByPlatformId == null)
            throw new ArgumentNullException(nameof(gamesByPlatformId));
        return gamesByPlatformId;
    }

    public Task UpdateGameAsync(Game gameDto)
    {
        throw new NotImplementedException();
    }
}
