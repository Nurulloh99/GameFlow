using GameFlow.Dal.Entities;

namespace GameFlow.Repository.Services;

public class GenreRepository : IGenreRepository
{
    public Task DeleteGenreAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task InsertGenreAsync(Genre genre)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Genre>> SelectAllGenresAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Genre> SelectGenreByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Genre>> SelectGenresByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Genre>> SelectSubgenresByParentIdAsync(Guid parentId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGenreAsync(Genre genre)
    {
        throw new NotImplementedException();
    }
}
