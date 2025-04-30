using System.Web.Mvc;
using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public interface IGameService
{
    Task AddGameAsync(GameCreateDto gameDto);
    Task<GameGetDto> GetGameByKeyAsync(string key);
    Task<GameGetDto> GetGameByIdAsync(long id);
    Task<ICollection<GameGetDto>> GetGamesByPlatformIdAsync(long platformId);
    Task<ICollection<GameGetDto>> GetGamesByGenreIdAsync(long genreId);
    Task UpdateGameAsync(GameGetDto gameDto);
    Task DeleteGameAsync(string key);
    Task<FileContentResult> DownloadGameFileAsync(string key);
    Task<ICollection<GameGetDto>> GetAllGamesAsync();
}
