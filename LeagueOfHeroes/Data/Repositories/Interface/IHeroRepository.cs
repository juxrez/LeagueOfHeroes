using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories.Interface
{
    public interface IHeroRepository : IBaseRepository<Hero>
    {
    }
}
