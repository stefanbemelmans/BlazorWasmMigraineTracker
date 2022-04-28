using System;
using System.Net.Http;

namespace BlazorWasmMigraineTracker.WeatherApi
{
    public class WeatherApiHttpClient
    {
        private const string WeatherApiUrl = "http://api.weatherapi.com/v1/";
        public HttpClient WeatherApiClient = new HttpClient();
        private Uri WeatherApiUri = new Uri(WeatherApiUrl);

        public WeatherApiHttpClient()
        {
            // calling the full url in the page
            //WeatherApiClient.BaseAddress = WeatherApiUri;
        }
    }
}
