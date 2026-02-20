using Newtonsoft.Json;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        string url = "http://api.open-notify.org/iss-now.json";

        HttpClient client = new HttpClient();

        HttpResponseMessage response = client.GetAsync(url).Result;
        string jsonResponse = response.Content.ReadAsStringAsync().Result;


        var findISS = JsonConvert.DeserializeObject<Coordinates>(jsonResponse);

        string latitude = findISS.iss_position.latitude;
        string longitude = findISS.iss_position.longitude;
        
        string url1 = $"http://api.geonames.org/countryCodeJSON?lat={latitude}&lng={longitude}&username=Marc";

        HttpClient clients = new HttpClient();

        HttpResponseMessage responses = clients.GetAsync(url1).Result;
        string jsonResponses = responses.Content.ReadAsStringAsync().Result;


        var WhereISS = JsonConvert.DeserializeObject<Root>(jsonResponses);
        Console.WriteLine(url1);

        string countryName = WhereISS.countryName;
        string countryCode = WhereISS.countryName;


        do
        {
            Console.WriteLine($"{findISS}, {countryName}, {countryCode}");
            Thread.Sleep(2000);
        } while (true);



    }
}


    //1ª Llamada: COORDENADAS
    public class IssPosition
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class Coordinates
    {
        public string message { get; set; }
        public int timestamp { get; set; }
        public IssPosition iss_position { get; set; }
    }


    //2ª Llamada: CIUDADES
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        public string languages { get; set; }
        public string distance { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
    }







/* 

Lista de apis en github:
https://github.com/public-apis/public-apis 

*/