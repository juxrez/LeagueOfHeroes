using System;

namespace LeagueOfHeroes.Data.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public Hero Hero { get; set; }
        public int Stars { get; set; }
        public string RatingBy { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
