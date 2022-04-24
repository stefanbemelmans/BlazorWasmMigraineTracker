namespace BlazorWasmMigraineTracker.Weather
{
    using System.Text.Json;
    using System.Threading.Tasks;
  
  public partial class WeatherForecastsPage 
    {  
    private const string RouteTemplate = "/WeatherForecasts";

    public static string GetRoute() => RouteTemplate;

        public Current
    public void GetCurrentWeather(string date, int? days, string fType, int? hour)
    {
            System.Net.Http.HttpResponseMessage responseMessage = Client.WeatherApiClient.GetAsync(url).Result;

            responseMessage.EnsureSuccessStatusCode();
            string stringResponse = responseMessage.Content.ReadAsStringAsync().Result;

            var current = JsonSerializer.Deserialize<GetWeatherForecastsResponse>(stringResponse);


        }
    protected override async Task OnInitializedAsync() =>
      
  }
}
