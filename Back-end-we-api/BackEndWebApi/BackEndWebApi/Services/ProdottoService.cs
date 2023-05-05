using BackEndWebApi.Models;

namespace BackEndWebApi.Services
{
    public class ProdottoService : IProdotti
    {


        public ProdottoService() { }



        /**

            simulazione di un datase
        **/
        public static List<Prodotto> prodotti = new List<Prodotto>
        {

            new Prodotto{Id = 1 , Nome="item1" , Prezzo=30 , Descrizione="Desc 1" },
            new Prodotto{Id = 2 , Nome="item2" , Prezzo=70 , Descrizione="Desc 2" },

        };



        public List<Prodotto> GetAllProdotti()
        {
            return prodotti;
        }

        public List<Prodotto> AddProdotto(Prodotto prodotto)
        {
            prodotti.Add(prodotto);
            return prodotti;
        }

        public Prodotto UpdateProdotto(int id, Prodotto prodotto)
        {

            var prodottTemp = prodotti.Find(x => x.Id == id);

            if(prodottTemp is null) {
                return null;
            }

            //update

            prodottTemp.Prezzo = prodotto.Prezzo;
            prodottTemp.Descrizione = prodotto.Descrizione;
            prodottTemp.Id = prodotto.Id;
            prodottTemp.Nome = prodotto.Nome;


            return prodotto;
        }

        public Prodotto DeleteProdotto(int id)
        {

            var prodottTemp = prodotti.Find(x => x.Id == id);
            if (prodottTemp is null)
            {
                return null;
            }

            prodotti.Remove(prodottTemp);

            return prodottTemp;

        }
    }
}
