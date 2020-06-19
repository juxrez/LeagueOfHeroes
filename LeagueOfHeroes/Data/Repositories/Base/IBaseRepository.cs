using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Data.Repositories.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetSingleAsync(Func<TEntity, bool> predicate);
        Task<List<TEntity>> GetAsync(Func<TEntity, bool> predicate);
        Task<List<TEntity>> GetAllAsync();

    }
}
