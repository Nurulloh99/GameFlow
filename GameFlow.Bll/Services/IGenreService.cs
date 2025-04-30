using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public interface IGenreService
{
    Task AddGenreAsync(GenreCreateDto genreCreateDto);
    Task<GenreGetDto> GetGenreByIdAsync(Guid id);
    Task<ICollection<GenreGetDto>> GetAllGenresAsync();
    Task<ICollection<GenreGetDto>> GetGenresByGameKeyAsync(string key);
    Task<ICollection<GenreGetDto>> GetSubgenresByParentIdAsync(Guid parentId);
    Task UpdateGenreAsync(GenreGetDto genreGetDto);
    Task DeleteGenreAsync(Guid id);
}
