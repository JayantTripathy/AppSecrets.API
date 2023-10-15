namespace AppSecrets.API.Models
{
    public class AppConfiguration
    {
        public string ApiKey { get; set; }
        public ApiHost ApiHost { get; set; }
    }
    public class ApiHost
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
    }
}
