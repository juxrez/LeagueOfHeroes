using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Data.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories.Interface
{
    public interface IHeroRepository : IBaseRepository<Hero>
    {
        Task<List<Hero>> GetAllHeroesWithReviews();
    }
}
