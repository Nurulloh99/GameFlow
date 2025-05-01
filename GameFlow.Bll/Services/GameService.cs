using System.Web.Mvc;
using AutoMapper;
using GameFlow.Bll.DTOs;
using GameFlow.Bll.MappingProfiles;
using GameFlow.Dal;
using GameFlow.Dal.Entities;
using GameFlow.Repository.Services;
using Microsoft.EntityFrameworkCore;

namespace GameFlow.Bll.Services;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;
    private readonly MainContext _context;
    private readonly IMapper _mappingProfiles;

    public GameService(IGameRepository gameRepository, MainContext context, AutoMapping _mappingProfiles)
    {
        _gameRepository = gameRepository;
        _context = context;
        _mappingProfiles = _mappingProfiles;
    }

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

    public Task<GameGetDto> GetGameByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<GameGetDto> GetGameByKeyAsync(string key)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(nameof(key));

        var game = await _gameRepository.SelectGameByKeyAsync(key);
        if (game == null)
            throw new KeyNotFoundException($"Game with key '{key}' not found.");

        var gameDto = _mappingProfiles.Map<GameGetDto>(game);
        return gameDto;
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
