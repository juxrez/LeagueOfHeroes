using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueOfHeroes.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeagueOfHeroes.Controllers
{
    public class HeroController : Controller
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [Route("heroes")]
        public async Task<ActionResult> Index()
        {
            try
            {
                var heroes = await _heroService.GetAllHeroesAsync();
                return View(heroes);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [Route("seed")]
        public async Task<ActionResult> SeedData()
        {
            try
            {

                return View("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
