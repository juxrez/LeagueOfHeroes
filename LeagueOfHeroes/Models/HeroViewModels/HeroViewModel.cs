using LeagueOfHeroes.Models.RatingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Models.HeroViewModels
{
    public class HeroViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Picture { get; set; }
        public RatingViewModel Rating { get; set; }
    }
}
