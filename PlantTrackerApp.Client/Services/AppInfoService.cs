using System.Net.Http.Json;

namespace PlantTrackerApp.Client.Services
{
    public class AppInfoService
    {
        private readonly HttpClient _http;

        public AppInfoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> GetVersionAsync()
        {
            var result = await _http.GetFromJsonAsync<VersionResponse>("api/appinfo/version");
            return result?.Version ?? "unknown";
        }

        private class VersionResponse
        {
            public string? Version { get; set; }
        }
    }
}
