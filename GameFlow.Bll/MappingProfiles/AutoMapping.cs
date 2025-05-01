using AutoMapper;
using GameFlow.Bll.DTOs;
using GameFlow.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFlow.Bll.MappingProfiles
{
   public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<GameCreateDto, Game>();
            CreateMap<Game, GameGetDto>();
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<Platform, PlatformGetDto>();
            CreateMap<GenreCreateDto, Genre>();
            CreateMap<Genre, GenreGetDto>();
        }
    }
}
