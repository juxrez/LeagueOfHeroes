using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories.Base
{
    public class BaseRepository<Tentity> : IBaseRepository<Tentity> where Tentity : class
    {
    }
}
