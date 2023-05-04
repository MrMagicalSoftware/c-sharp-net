using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services.SuperHeroSerrvice;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {Id = 1 ,
                 Name="spiderman" ,
                 FirstName ="PETER" ,
                LastName="PARKER" ,
                  Place="ny"}
            };

        private SuperHeroService  _superHeroService;

        public SuperHeroController(SuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHero>>> GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);

            if(hero is null)
            {
                return NotFound("SORRY NO HERO FOUND");
            }

            return Ok(hero);
        }



        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return Ok(hero);
        }



        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {

            /*
            var superHeroes = new List<SuperHero>
            {
                new SuperHero
                {Id = 1 ,
                 Name="spiderman" ,
                 FirstName ="PETER" ,
                LastName="PARKER" ,
                  Place="ny"}
            };
            */

            return Ok(superHeroes);
        }




        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id , SuperHero request)
        {

            var hero = superHeroes.Find(x => x.Id == id);

            if (hero is null)
            {
                return NotFound("SORRY NO HERO FOUND");
            }

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;

            // mancano gli altri attributi.. . .. 

            return Ok(superHeroes);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteHero(int id)
        {

            var hero = superHeroes.Find(x => x.Id == id);

            if (hero is null)
            {
                return NotFound("SORRY NO HERO FOUND");
            }

            superHeroes.Remove(hero);
            return Ok(superHeroes);
        }




    }
}
