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
        //TODO: Import Context
        public BaseRepository()
        {

        }

        public Task<List<TEntity>> GetAsync(Func<TEntity, bool> predicate)
        {
            var result = new List<TEntity>();
            using (StreamReader file = File.OpenText(@"c:\Data.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                result = JsonConvert.DeserializeObject<List<TEntity>>(o2.ToString());
            }
            return Task.FromResult(result.Where(predicate).ToList());
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            var result = new List<TEntity>();
            JObject o1 = JObject.Parse(File.ReadAllText(@"c:\data.json"));
            //using (StreamReader file = File.OpenText(@"c:\Data.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //    result = JsonConvert.DeserializeObject<List<TEntity>>(o2.ToString());
            //}
            result = JsonConvert.DeserializeObject<List<TEntity>>(o1.ToString());
            return Task.FromResult(result);
        }

        public Task<TEntity> GetSingleAsync(Func<TEntity, bool> predicate)
        {
            var result = new List<TEntity>();
            using (StreamReader file = File.OpenText(@"c:\Data.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                result = JsonConvert.DeserializeObject<List<TEntity>>(o2.ToString());
            }
            return Task.FromResult(result.Where(predicate).FirstOrDefault());
        }
    }
}
