using System.Web.Mvc;
using GameFlow.Bll.DTOs;
using GameFlow.Dal;
using GameFlow.Dal.Entities;
using GameFlow.Repository.Services;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Bll.Services;

public class GameService(IGameRepository _gameRepository, MainContext _context) : IGameService
{
    public async Task AddGameAsync(GameCreateDto gameDto)
    {
        if(gameDto == null)
            throw new ArgumentNullException(nameof(gameDto));

        var game = new Game
        {
            GameDescription = gameDto.GameDescription,
            GameName = gameDto.GameName,
            GameKey = gameDto.GameKey,
            GameGenres = GetAllGameGenres(gameDto),
            GamePlatforms = GetAllGamePlatforms(gameDto),

        };

        await _gameRepository.InsertGameAsync(game);
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

    public async Task<GameGetDto> GetGameByIdAsync(Guid id)
    {
        var game = await _context.Games.FindAsync(id);
        if (game == null)
            throw new ArgumentNullException(nameof(game));
        return new GameGetDto
        {
            GameId = game.GameId,
            GameName = game.GameName,
            GameKey = game.GameKey,
            GameDescription = game.GameDescription,
            //GameGenres = game.GameGenres,
            //GamePlatforms = game.GamePlatforms
        };
    }

    public Task<GameGetDto> GetGameByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GameGetDto>> GetGamesByGenreIdAsync(Guid genreId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GameGetDto>> GetGamesByPlatformIdAsync(Guid platformId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGameAsync(GameGetDto gameDto)
    {
        throw new NotImplementedException();
    }

    public ICollection<GameGenre> GetAllGameGenres(GameCreateDto gameDto)
    {
        var genres = _context.GameGenres.ToList();
        List<GameGenre> GameGenres = new List<GameGenre>();

        foreach (var genre in gameDto.GameGenres)
        {
            var g = genres.FirstOrDefault (x => x.GenreId == genre);
            if (g is not null)
                GameGenres.Add(g);
        }

        return GameGenres;
    }

    public ICollection<GamePlatform> GetAllGamePlatforms(GameCreateDto gameDto)
    {
        var platforms = _context.GamePlatforms.ToList();
        List<GamePlatform> GamePlatforms = new List<GamePlatform>();

        foreach (var platform in gameDto.GamePlatforms)
        {
            var g = platforms.FirstOrDefault(x => x.PlatformId == platform);
            if (g is not null)
                GamePlatforms.Add(g);
        }

        return GamePlatforms;
    }
}
