using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Data.Repositories.Base;
using LeagueOfHeroes.Data.Repositories.Interface;

namespace LeagueOfHeroes.Data.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(LeagueOfHeroesContext context) : base(context)
        {
        }
    }
}
