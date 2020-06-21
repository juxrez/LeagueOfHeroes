using AutoMapper;
using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Models;
using LeagueOfHeroes.Models.HeroViewModels;
using LeagueOfHeroes.Models.RatingViewModels;
using System.Linq;

namespace LeagueOfHeroes.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hero, HeroDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.Ratings, opt => opt.MapFrom(src => src.Reviews));

            CreateMap<HeroDTO, HeroViewModel>()
                .ForMember(dest => dest.Score, opt => opt.MapFrom(src => 
                    src.Ratings.Average(r => r.Stars)));

            CreateMap<Rating, RatingViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.HeroId, opt => opt.MapFrom(src => src.HeroId))
                .ForMember(dest => dest.RatingBy, opt => opt.MapFrom(src => src.RatingBy))
                .ForMember(dest => dest.Stars, opt => opt.MapFrom(src => src.Stars))
                .ForMember(dest => dest.RatingDate, opt => opt.MapFrom(src => src.RatingDate));
        }
    }
}
