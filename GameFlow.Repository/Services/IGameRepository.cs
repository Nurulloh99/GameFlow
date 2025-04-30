using System.Web.Mvc;
using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public interface IGameRepository
{
    Task InsertGameAsync(Game game);
    Task<Game> SelectGameByKeyAsync(string key);
    Task<Game> SelectGameByIdAsync(long id);
    Task<ICollection<Game>> SelectGamesByPlatformIdAsync(long platformId);
    Task<ICollection<Game>> SelectGamesByGenreIdAsync(long genreId);
    Task UpdateGameAsync(Game gameDto);
    Task DeleteGameAsync(string key);
    Task<FileContentResult> DownloadGameFileAsync(string key);
    Task<ICollection<Game>> SelectAllGamesAsync();
}