using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public interface IGenreRepository
{
    Task InsertGenreAsync(Genre genre);
    Task<Genre> SelectGenreByIdAsync(Guid id);
    Task<ICollection<Genre>> SelectAllGenresAsync();
    Task<ICollection<Genre>> SelectGenresByGameKeyAsync(string key);
    Task<ICollection<Genre>> SelectSubgenresByParentIdAsync(Guid parentId);
    Task UpdateGenreAsync(Genre genre);
    Task DeleteGenreAsync(Guid id);
}