using GameFlow.Bll.DTOs;

namespace GameFlow.Bll.Services;

public interface IGenreService
{
    Task AddGenreAsync(GenreCreateDto genreCreateDto);
    Task<GenreGetDto> GetGenreByIdAsync(long id);
    Task<ICollection<GenreGetDto>> GetAllGenresAsync();
    Task<ICollection<GenreGetDto>> GetGenresByGameKeyAsync(string key);
    Task<ICollection<GenreGetDto>> GetSubgenresByParentIdAsync(long parentId);
    Task UpdateGenreAsync(GenreGetDto genreGetDto);
    Task DeleteGenreAsync(long id);
}
