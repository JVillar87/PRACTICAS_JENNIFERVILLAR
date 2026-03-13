using Newtonsoft.Json;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://www.swapi.tech/api/starships?page=2&limit=10"; //endpoint starships

        HttpClient client = new HttpClient();

        HttpResponseMessage response = client.GetAsync(url).Result;
        string jsonResponse = response.Content.ReadAsStringAsync().Result;
        HttpClient clients = new HttpClient();
        Root starships = JsonConvert.DeserializeObject<Root>(jsonResponse);

        do
        {
            int i = 0;
            for (i = 0; i < starships.results.Count; i++)
            if (starships.results[i].name != null)
            {

                Console.WriteLine($"NAME: {starships.results[i].name}, UID: {starships.results[i].uid}");
                Thread.Sleep(2000);
            }
            else
            {
                {
                    Console.WriteLine("Error: No hay información sobre la nave espacial.");
                    break;
                }
            }

            i++;

        } while (true);
    }
}