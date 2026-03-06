using Newtonsoft.Json;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://www.swapi.tech/api/starships/9"; //endpoint starships

        HttpClient client = new HttpClient();

        HttpResponseMessage response = client.GetAsync(url).Result;
        string jsonResponse = response.Content.ReadAsStringAsync().Result;
        HttpClient clients = new HttpClient();
        Root starships = JsonConvert.DeserializeObject<Root>(jsonResponse);

        do
        {
            if (starships != null && starships.result != null && starships.result.properties != null)
            {
                Console.WriteLine($"NAME: {starships.result.properties.name}, MODEL: {starships.result.properties.model}, MANUFACTURER: {starships.result.properties.manufacturer}");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Error: No hay información sobre la nave espacial.");
                break;
            }
            
                        
        } while (true);



    }
}
