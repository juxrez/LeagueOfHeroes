using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly LeagueOfHeroesContext _context;

        public BaseRepository(LeagueOfHeroesContext context)
        {
            _context = context;
        }

        public virtual Task<List<TEntity>> GetAsync(Func<TEntity, bool> predicate)
        {
            var result = _context.Set<TEntity>().Where(predicate).ToList();
            return Task.FromResult(result);
        }

        public virtual Task<List<TEntity>> GetAllAsync()
        {
            var result = _context.Set<TEntity>().ToList();
            return Task.FromResult(result);
        }

        public virtual Task<TEntity> GetSingleAsync(Func<TEntity, bool> predicate)
        {
            var result = _context.Set<TEntity>().Where(predicate).FirstOrDefault();
            return Task.FromResult(result);
        }
    }
}
