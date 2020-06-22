using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Models.HeroViewModels;
using LeagueOfHeroes.Models.RatingViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace LeagueOfHeroes.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        
        public static void Seed(this ModelBuilder modelBuilder, IWebHostEnvironment env)
        {
            var heroesFile = env.ContentRootFileProvider.GetFileInfo(Path.Combine("Data", "Seed", "Heroes.json"));
            var ratingsFile = env.ContentRootFileProvider.GetFileInfo(Path.Combine("Data", "Seed", "Ratings.json"));

            if (heroesFile.Exists)
            {
                try
                {
                    var heroesReader = new StreamReader(heroesFile.CreateReadStream());
                    JObject heroesJson = JObject.Parse(heroesReader.ReadToEnd());
                    var heroesData = JsonConvert.DeserializeObject<HeroesViewModel>(heroesJson.ToString());

                    foreach (var heroe in heroesData.Heroes)
                    {
                        modelBuilder.Entity<Hero>().HasData(
                            new Hero()
                            {
                                Id = heroe.Id,
                                Name = heroe.Name,
                                Age = heroe.Age,
                                City = heroe.City,
                                Picture = heroe.Picture
                            });
                    }
                    
                    //if at this point Heroes are seeded, we can seed reviews
                    if(ratingsFile.Exists)
                    {
                        var ratingsReader = new StreamReader(ratingsFile.CreateReadStream());
                        JObject ratingsJson = JObject.Parse(ratingsReader.ReadToEnd());
                        var ratingsData = JsonConvert.DeserializeObject<RatingsViewModel>(ratingsJson.ToString());

                        foreach(var rating in ratingsData.Ratings)
                        {
                            modelBuilder.Entity<Rating>().HasData(
                                new Rating()
                                {
                                    Id = rating.Id,
                                    Stars = rating.Stars,
                                    HeroId =  rating.HeroId,
                                    RatingDate = rating.RatingDate,
                                    RatingBy = rating.RatingBy
                                });
                        }
                    }
                }
                catch 
                {
                    //Log message unable to seed data
                }
            }
        }
    }
}
