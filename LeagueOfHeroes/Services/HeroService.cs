using AutoMapper;
using LeagueOfHeroes.Data.Repositories.Interface;
using LeagueOfHeroes.Models.HeroViewModels;
using LeagueOfHeroes.Services.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;
        private readonly IMapper _mapper;

        private readonly List<HeroViewModel> heroData;

        public HeroService(
            IHeroRepository heroRepository,
            IMapper mapper)
        {
            _heroRepository = heroRepository;
            _mapper = mapper;
        }
        public  Task<List<HeroViewModel>> GetAllHeroesAsync()
        {
            //var hereos = await _heroRepository.GetAllAsync();
            //var map = _mapper.Map<List<HeroViewModel>>(hereos);
            //return map;
            var result = new HeroesViewModel();
            JObject o1 = JObject.Parse(File.ReadAllText(@"c:\data.json"));
            
            result = JsonConvert.DeserializeObject<HeroesViewModel>(o1.ToString());
            //var map = _mapper.Map<List<HeroViewModel>>(result.);
            return Task.FromResult(result.Heroes);
        }

        public Task<HeroViewModel> GetHeroByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
