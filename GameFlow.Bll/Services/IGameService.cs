using System.Web.Mvc;
using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public interface IGameService
{
    Task AddGameAsync(GameCreateDto gameDto);
    Task<GameGetDto> GetGameByKeyAsync(string key);
    Task<GameGetDto> GetGameByIdAsync(Guid id);
    Task<ICollection<GameGetDto>> GetGamesByPlatformIdAsync(Guid platformId);
    Task<ICollection<GameGetDto>> GetGamesByGenreIdAsync(Guid genreId);
    Task UpdateGameAsync(GameGetDto gameDto);
    Task DeleteGameAsync(string key);
    Task<FileContentResult> DownloadGameFileAsync(string key);
    Task<ICollection<GameGetDto>> GetAllGamesAsync();
}
