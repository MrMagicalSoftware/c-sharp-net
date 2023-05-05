using BackEndWebApi.Models;
using BackEndWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEndWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProdottoController : ControllerBase
    {
        
        private readonly IProdotti _ProdottoService; // IProdotti!!

        //DI

        public ProdottoController(IProdotti prodottoService)
        {
            _ProdottoService = prodottoService;
        }


        [HttpGet]
        public  IEnumerable<Prodotto> getSomeProducts()
        {
            
            return _ProdottoService.GetAllProdotti();

        }

        [HttpPost]
        public async Task<IActionResult> AddProdotto(Prodotto prodotto)
        {
            return Ok(_ProdottoService.AddProdotto(prodotto));
        }



        [HttpPut]
        public async Task<IActionResult> UpdateProdotto(int id, Prodotto prodotto)
        {
            Prodotto prodottoTmp = _ProdottoService.UpdateProdotto(id, prodotto);

            if(prodottoTmp is null)
            {
                return NotFound("nESSUNA MODIFICA SVOLTA");
            }

            return Ok(prodottoTmp);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteProdotto(int id)
        {

            Prodotto p = _ProdottoService.DeleteProdotto(id);

            if (p is null)
                return NotFound("nessuno rimosso");

            return Ok(p);

        }


    }
}
