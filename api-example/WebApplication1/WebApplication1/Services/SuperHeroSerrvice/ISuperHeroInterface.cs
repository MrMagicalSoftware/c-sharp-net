using WebApplication1.Models;

namespace WebApplication1.Services.SuperHeroSerrvice
{
    public interface ISuperHeroInterface
    {

        List<SuperHero> GetAllHeros();
        SuperHero GetSingleHero(int id);

        List<SuperHero> AddHero(SuperHero hero);

        List<SuperHero> DeleteHero(int id);


    }
}
