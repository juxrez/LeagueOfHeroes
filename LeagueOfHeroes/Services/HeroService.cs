using AutoMapper;
using LeagueOfHeroes.Data.Repositories.Interface;
using LeagueOfHeroes.Infrastructure.Extensions;
using LeagueOfHeroes.Models;
using LeagueOfHeroes.Models.HeroViewModels;
using LeagueOfHeroes.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;
        private readonly IMapper _mapper;

        public HeroService(
            IHeroRepository heroRepository,
            IMapper mapper)
        {
            _heroRepository = heroRepository;
            _mapper = mapper;
        }
        public async Task<HeroesViewModel> GetAllHeroesAsync()
        {
            var heroes = await _heroRepository.GetAllHeroesWithReviews().ConfigureAwait(false);
            var heroesDto = _mapper.Map<List<HeroDTO>>(heroes);
            await heroesDto.CalculateMedian();

            var sortedHeroes = heroesDto.OrderByDescending(h => h.Median).ToList();
            var vm = _mapper.Map<List<HeroViewModel>>(sortedHeroes);
            
            var result = new HeroesViewModel()
            {
                HasError = false,
                Heroes = vm
            };

            return result;
        }

        public Task<HeroViewModel> GetHeroByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
