namespace BlazorWasmMigraineTracker.Dtos.Weather
{
    public class Location
    {
        public decimal lat { get; set; } //Latitude
        public decimal lon { get; set; } // longitude
        public string name { get; set; } // location name
        public string region { get; set; } // state of the location, if availa
        public string country { get; set; }// Location country
        public string tz_id { get; set; } //Time zone name
        public int localtime_epoch { get; set; }//   Local date and time in unix time
        public string localtime { get; set; }
    }
}
