using AutoMapper;
using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Models.HeroViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hero, HeroViewModel>();
            CreateMap<HeroViewModel, Hero>();
        }
    }
}
