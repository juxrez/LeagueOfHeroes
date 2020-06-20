using LeagueOfHeroes.Models.RatingViewModels;
using System.Collections.Generic;

namespace LeagueOfHeroes.Models.HeroViewModels
{
    public class HeroesViewModel
    {
        public List<HeroViewModel> Heroes { get; set; }
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
    }
}
