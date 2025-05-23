﻿using GameFlow.Dal.Entities;

namespace GameFlow.Bll.DTOs;

public class PlatformGetDto
{
    public Guid PlatformId { get; set; }
    public string PlatformType { get; set; }

    public ICollection<GamePlatform> GamePlatforms { get; set; }
}
