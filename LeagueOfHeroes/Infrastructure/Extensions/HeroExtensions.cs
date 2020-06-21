using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Models;
using LeagueOfHeroes.Models.RatingViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfHeroes.Infrastructure.Extensions
{
    public static class HeroExtensions
    {
        public static Task CalculateMedian(this List<HeroDTO> heroes)
        {
            Parallel.ForEach(heroes, (hero) =>
            {
                //if there are ratings
                if (hero.Ratings.Any())
                {
                    int numberOfratings = hero.Ratings.Count();

                    if (numberOfratings > 1)
                    {
                        bool isEven = numberOfratings % 2 == 0;

                        try
                        {
                            if (isEven)
                            {
                                hero.Median = GetMedianFromEvenList(
                                    hero.Ratings.OrderByDescending(r => r.Stars).ToList());
                            }
                            else
                            {
                                hero.Median = GetMedianFromOddList(hero.Ratings);
                            }
                        }
                        catch
                        {
                            //if something goes wrong 
                            hero.Median = 0;
                        }
                    }
                    else
                    {
                        //if there is only one record thats the median result
                        hero.Median = hero.Ratings[0].Stars;
                    }
                }
                else 
                {
                    //if no ratings for the heroe
                    hero.Median = 0;
                }
            });

            
            return Task.CompletedTask;
        }

        #region Private Methods
        private static int GetMedianFromEvenList(List<RatingViewModel> ratings)
        {
            int half = ratings.Count() / 2;
            var median = (ratings.ElementAt(half).Stars
                - ratings.ElementAt(half - 1).Stars / 2);
            return median;
        }

        private static int GetMedianFromOddList(List<RatingViewModel> ratings)
        {
            int half = ratings.Count() / 2;
            return ratings.ElementAt(half).Stars;
        }

        //private static int GetTheHalfIndexFromList(int lenght)
        //{
        //    decimal half = lenght / 2;
        //    if(half % 1 == 0)
        //    {
        //        return (int)half;
        //    }
        //    else
        //    {
        //        return (int)(half + .5M);
        //    }
        //}
        #endregion
    }
}
