namespace BlazorWasmMigraineTracker.Dtos.Weather
{
    public class GetCurrentWeatherResponse
    {
        public Current Current { get; set; }
        public Location Location { get; set; }

        public Forecast Forecast { get; set; }
        /// <summary>
        /// a default constructor is required for client side deserialization
        /// </summary>
        public GetCurrentWeatherResponse ()
        {
            Current = new Current();
            Location = new Location (); 
            Forecast = new Forecast ();
        }
    }
}
