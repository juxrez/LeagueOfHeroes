using LeagueOfHeroes.Models.HeroViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Services.Interface
{
    public interface IHeroService
    {
        Task<List<HeroViewModel>> GetAllHeroesAsync();
        Task<HeroViewModel> GetHeroByIdAsync();
    }
}
