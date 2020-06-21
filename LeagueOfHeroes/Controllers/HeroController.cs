using System;
using System.Threading.Tasks;
using LeagueOfHeroes.Models.HeroViewModels;
using LeagueOfHeroes.Services.Interface;
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
            var heroesVm = new HeroesViewModel();
            try
            {
                heroesVm = await _heroService.GetAllHeroesAsync();
            }
            catch (Exception ex)
            {
                heroesVm.HasError = true;
                heroesVm.ErrorMessage = ex.InnerException?.Message ?? ex.Message;
            }

            return View(heroesVm);
        }
    }
}
