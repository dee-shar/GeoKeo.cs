using System.Net.Http;

namespace GeoKeoApi
{
    public class GeoKeo
    {
        private readonly string apiKey;
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://geokeo.com/geocode/v1";
        public GeoKeo(string apiKey)
        {
            this.apiKey = apiKey;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> ForwardGeocode(string query)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/search.php?q={query}&api={apiKey}");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> ReverseGeocode(double latitude, double longitude)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/reverse.php?lat={latitude}&lng={longitude}&api={apiKey}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
