using Newtonsoft.Json;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        string url = "http://api.open-notify.org/iss-now.json"; //endpoint coordenadas

        HttpClient client = new HttpClient();

        HttpResponseMessage response = client.GetAsync(url).Result;
        string jsonResponse = response.Content.ReadAsStringAsync().Result;


        var findISS = JsonConvert.DeserializeObject<Coordinates>(jsonResponse);

        string latitude = findISS.iss_position.latitude;
        string longitude = findISS.iss_position.longitude;
        
        string url1 = $"http://api.geonames.org/countryCodeJSON?lat={latitude}&lng={longitude}&username=Marc"; //endpoint ciudades (wheretheiss)

        HttpClient clients = new HttpClient();

        HttpResponseMessage responses = clients.GetAsync(url1).Result;
        string jsonResponses = responses.Content.ReadAsStringAsync().Result;


        var WhereISS = JsonConvert.DeserializeObject<Countries>(jsonResponses);
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





/* 

Lista de apis en github:
https://github.com/public-apis/public-apis 

*/