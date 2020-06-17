using System.Collections.Generic;

namespace LeagueOfHeroes.Data.Entities
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Picture { get; set; }
        public List<Rating> Reviews { get; set; }
    }
}
