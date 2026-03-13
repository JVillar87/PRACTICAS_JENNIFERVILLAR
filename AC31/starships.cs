// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class HeartMath
    {
        public string link { get; set; }
        public string details { get; set; }
    }

    public class PartnerDiscounts
    {
        public SaberMasters saberMasters { get; set; }
        public HeartMath heartMath { get; set; }
    }

    public class Result
    {
        public string uid { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Root
    {
        public string message { get; set; }
        public int total_records { get; set; }
        public int total_pages { get; set; }
        public string previous { get; set; }
        public string next { get; set; }
        public List<Result> results { get; set; }
        public string apiVersion { get; set; }
        public DateTime timestamp { get; set; }
        public Support support { get; set; }
        public Social social { get; set; }
    }

    public class SaberMasters
    {
        public string link { get; set; }
        public string details { get; set; }
    }

    public class Social
    {
        public string discord { get; set; }
        public string reddit { get; set; }
        public string github { get; set; }
    }

    public class Support
    {
        public string contact { get; set; }
        public string donate { get; set; }
        public PartnerDiscounts partnerDiscounts { get; set; }
    }

