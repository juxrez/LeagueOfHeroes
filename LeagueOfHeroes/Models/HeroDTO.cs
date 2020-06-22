using LeagueOfHeroes.Models.RatingViewModels;
using System.Collections.Generic;

namespace LeagueOfHeroes.Models
{
    public class HeroDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Picture { get; set; }
        public string Score { get; set; }
        public double Median { get; set; }
        public List<RatingViewModel> Ratings { get; set; }
    }
}
