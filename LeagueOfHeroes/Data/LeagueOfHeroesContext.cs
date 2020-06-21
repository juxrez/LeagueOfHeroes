using LeagueOfHeroes.Data.Entities;
using LeagueOfHeroes.Infrastructure.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace LeagueOfHeroes.Data
{
    public class LeagueOfHeroesContext : DbContext
    {
        private readonly IWebHostEnvironment _env;
        public LeagueOfHeroesContext(
            DbContextOptions<LeagueOfHeroesContext> options, 
            IWebHostEnvironment env) : base(options)
        {
            _env = env;
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hero>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(r => r.Hero)
                .WithMany(h => h.Reviews);
            });

            modelBuilder.Seed(_env);
        }
    }
}
