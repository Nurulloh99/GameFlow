using GameFlow.Bll.DTOs;
using GameFlow.Bll.Services;
using GameFlow.Dal.Entities;
using GameFlow.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameFlow.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController(IGameService _gameService) : ControllerBase
{
    [HttpPost("/games")]
    public async Task AddGameAsync(GameCreateDto creteGameDto)
    {
        await _gameService.AddGameAsync(creteGameDto);
    }

    [HttpGet("/games/{key}")]
    public async Task<ActionResult<GameGetDto>> GetGameByKeyAsync(string key)
    {

        var game = await _gameService.GetGameByKeyAsync(key);

        return Ok(game);
    }

    [HttpGet("/games/find/{id}")]
    public async Task<ActionResult<GameGetDto>> GetGameByIdAsync(Guid Id)
    {
        var game = await _gameService.GetGameByIdAsync(Id);

        return Ok(game);
    }

    [HttpGet("/platforms/{id}/games")]
    public async Task<ActionResult<List<GameGetDto>>> GetGamesByPlatformIdAsync(Guid platformId)
    {
        var games = await _gameService.GetGamesByPlatformIdAsync(platformId);

        return Ok(games);
    }

    [HttpGet("/genres/{id}/games")]
    public async Task<ActionResult<List<GameGetDto>>> GetGamesByGenreIdAsync(Guid genreId)
    {
        var games = await _gameService.GetGamesByGenreIdAsync(genreId);

        return Ok(games);
    }

    //[HttpPut("/games")]
    //public async Task<ActionResult> 
    [HttpDelete("/games/{key}")]
    public async Task DeleteGameByKey(string key)
    {
        await _gameService.DeleteGameAsync(key);
    }

    [HttpGet("/games/{key}/file")]
    public async Task<ActionResult<FileContentResult>> DownloadGameFileAsync(string key)
    {
        var file = await _gameService.DownloadGameFileAsync($"{key}");

        return Ok(file);
    }

    [HttpGet("/games")]
    public async Task<ActionResult<List<GameGetDto>>> GetAllGamesAsync()
    {
        var games = await _gameService.GetAllGamesAsync();

        return Ok(games);
    }


}
