﻿using GameFlow.Dal.Entities;

namespace GameFlow.Bll.DTOs;

public class GameGetDto
{
    public Guid GameId { get; set; }
    public string GameName { get; set; }
    public string GameKey { get; set; }
    public string? GameDescription { get; set; }

    //public ICollection<GameGenre> GameGenres { get; set; }
    //public ICollection<GamePlatform> GamePlatforms { get; set; }
}
