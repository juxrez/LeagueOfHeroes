using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly LeagueOfHeroesContext _context;

        public BaseRepository(LeagueOfHeroesContext context)
        {
            _context = context;
        }

        public Task<List<TEntity>> GetAsync(Func<TEntity, bool> predicate)
        {

            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetSingleAsync(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
