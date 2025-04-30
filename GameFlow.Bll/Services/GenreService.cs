using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public class GenreService : IGenreService
{
    public Task AddGenreAsync(GenreCreateDto genreCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGenreAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GenreGetDto>> GetAllGenresAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GenreGetDto> GetGenreByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GenreGetDto>> GetGenresByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GenreGetDto>> GetSubgenresByParentIdAsync(Guid parentId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGenreAsync(GenreGetDto genreGetDto)
    {
        throw new NotImplementedException();
    }
}
