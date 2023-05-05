using BackEndWebApi.Models;

namespace BackEndWebApi.Services
{
    public interface IProdotti
    {



        List<Prodotto> GetAllProdotti();


        List<Prodotto> AddProdotto(Prodotto prodotto);

        // Operazione di update sul prodotto.
        Prodotto UpdateProdotto(int id , Prodotto prodotto);


        Prodotto DeleteProdotto(int id);

    }
}
