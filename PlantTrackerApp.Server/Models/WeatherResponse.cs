namespace PlantTrackerApp.Server.Models
{
    public class WeatherResponse
    {
        public required Daily daily { get; set; }

        public class Daily
        {
            public required List<string> time { get; set; }
            public required List<double> precipitation_sum { get; set; }
        }
    }
}
