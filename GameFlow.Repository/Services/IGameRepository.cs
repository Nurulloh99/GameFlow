using System.Web.Mvc;
using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public interface IGameRepository
{
    Task InsertGameAsync(Game game);
    Task<Game> SelectGameByKeyAsync(string key);
    Task<Game> SelectGameByIdAsync(Guid id);
    Task<ICollection<Game>> SelectGamesByPlatformIdAsync(Guid platformId);
    Task<ICollection<Game>> SelectGamesByGenreIdAsync(Guid genreId);
    Task UpdateGameAsync(Game gameDto);
    Task DeleteGameAsync(string key);
    Task<FileContentResult> DownloadGameFileAsync(string key);
    Task<ICollection<Game>> SelectAllGamesAsync();
}