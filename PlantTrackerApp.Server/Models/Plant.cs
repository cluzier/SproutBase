namespace PlantTrackerApp.Server.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Species { get; set; }
        public DateTime LastWatered { get; set; }
        public string Tags { get; set; } = string.Empty;
    }
}
