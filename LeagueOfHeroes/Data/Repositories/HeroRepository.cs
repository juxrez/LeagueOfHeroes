using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Data.Repositories.Base;
using LeagueOfHeroes.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(LeagueOfHeroesContext context) : base(context)
        {
        }

        public async Task<List<Hero>> GetAllHeroesWithReviews()
        {
            return await _context.Heroes.Include(h => h.Reviews).ToListAsync();
        }
    }
}
