/* // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
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

    public class Properties
    {
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string consumables { get; set; }
        public string name { get; set; }
        public string cargo_capacity { get; set; }
        public string passengers { get; set; }
        public string max_atmosphering_speed { get; set; }
        public string crew { get; set; }
        public string length { get; set; }
        public string model { get; set; }
        public string cost_in_credits { get; set; }
        public string manufacturer { get; set; }
        public List<object> pilots { get; set; }
        public string MGLT { get; set; }
        public string starship_class { get; set; }
        public string hyperdrive_rating { get; set; }
        public List<string> films { get; set; }
        public string url { get; set; }
    }

    public class Result
    {
        public Properties properties { get; set; }
        public string _id { get; set; }
        public string description { get; set; }
        public string uid { get; set; }
        public int __v { get; set; }
    }

    public class Root
    {
        public string message { get; set; }
        public Result result { get; set; }
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

 */



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

