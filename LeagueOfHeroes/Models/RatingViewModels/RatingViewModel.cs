using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Models.RatingViewModels
{
    public class RatingViewModel
    {
        public double Value { get; set; }
        public int FullStars { get; set; }
        public bool HasMediumStar { get; set; }
    }
}
