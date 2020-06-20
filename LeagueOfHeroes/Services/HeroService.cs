using AutoMapper;
using LeagueOfHeroes.Data.Repositories.Interface;
using LeagueOfHeroes.Models.HeroViewModels;
using LeagueOfHeroes.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        public  Task<List<HeroViewModel>> GetAllHeroesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HeroViewModel> GetHeroByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
