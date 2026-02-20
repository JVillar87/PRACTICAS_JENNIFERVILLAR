
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
    public class Countries
    {
        public string languages { get; set; }
        public string distance { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
    }