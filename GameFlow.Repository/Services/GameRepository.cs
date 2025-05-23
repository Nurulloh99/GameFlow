﻿using System.Web.Mvc;
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

    public async Task<Game> SelectGameByIdAsync(Guid id)
    {
       var game = await _mainContext.Games.FindAsync(id);
        if (game == null)
            throw new ArgumentNullException(nameof(game));
        return game;
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

    public async Task<ICollection<Game>> SelectGamesByGenreIdAsync(Guid genreId)
    {
        var games = _mainContext.Games;
        var gamesByGenreId = await games.Where(x => x.GameGenres.Any(y => y.GenreId == genreId)).ToListAsync();
        if (gamesByGenreId == null)
            throw new ArgumentNullException(nameof(gamesByGenreId));
        return gamesByGenreId;
    }

    public async Task<ICollection<Game>> SelectGamesByPlatformIdAsync(Guid platformId)
    {
        var games = _mainContext.Games;
        var gamesByPlatformId = await games.Where(x => x.GamePlatforms.Any(y => y.PlatformId == platformId)).ToListAsync();
        if (gamesByPlatformId == null)
            throw new ArgumentNullException(nameof(gamesByPlatformId));
        return gamesByPlatformId;
    }

    public async Task UpdateGameAsync(Game gameDto)
    {
        var game = await _mainContext.Games.FirstOrDefaultAsync(x => x.Id == gameDto.Id);
        if (game == null)
            throw new ArgumentNullException(nameof(game));
        game.Name = gameDto.GameName;
        game.Description = gameDto.GameDescription;
        game.GameKey = gameDto.GameKey;
        await _mainContext.SaveChangesAsync();
    }
}
