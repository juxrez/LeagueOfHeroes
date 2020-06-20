using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Models.RatingViewModels
{
    public class RatingViewModel
    {
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int Stars { get; set; }
        public string RatingBy { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
