using RestSharp;
using System.Net.Http.Json;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        // Creazione del client per effettuare la richiesta
        var client = new RestClient("https://randomfox.ca/floof/");

        // Creazione della richiesta
        var request = new RestRequest("", Method.Get);
        //request.AddUrlSegment("id", "123"); // Passaggio di un parametro nella URL

        // Esecuzione della richiesta
        var response = client.Execute(request);


        //Deserialize


        var foxResponse = JsonSerializer.Deserialize<RestSharpExample.Fox>(response.Content);


        //.Serialization.Json.JsonSerializer();


        // Controllo della risposta del server
        if (response.IsSuccessful)
        {
            Console.WriteLine("Risposta del server:");
            Console.WriteLine(response.Content);

            Console.WriteLine("################");

            Console.WriteLine(foxResponse.aglieglie);
            Console.WriteLine(foxResponse.link);

            Console.WriteLine("################");

        }
        else
        {
            Console.WriteLine("Errore nella richiesta:");
            Console.WriteLine(response.ErrorMessage);
        }
    }
}
