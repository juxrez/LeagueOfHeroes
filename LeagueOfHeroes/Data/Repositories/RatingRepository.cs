using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Data.Repositories.Base;
using LeagueOfHeroes.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
    }
}
