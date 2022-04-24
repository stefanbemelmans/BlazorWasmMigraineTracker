namespace BlazorWasmMigraineTracker.Pages
{
    public class GetCurrentWeatherResponse
    {
        public Current current { get; set; }
        public Location location { get; set; }

        public Forecast forecast { get; set; }
        /// <summary>
        /// a default constructor is required for client side deserialization
        /// </summary>
        public  class GetCurrentWeatherResponse
()
        {
            //WeatherForecasts = new List<WeatherForecastDto>();
        }

    public public class GetCurrentWeatherResponse (Guid aCorrelationId) : base(aCorrelationId)
        {
            //WeatherForecasts = new List<WeatherForecastDto>();
        }

    }
}
}
