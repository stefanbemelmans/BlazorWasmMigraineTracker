namespace BlazorWasmMigraineTracker.Dtos.Weather
{
    public class AstroElement
    {
#pragma warning disable IDE1006 // Naming Styles
        public string? sunrise { get; set; } // time
        public string? sunset { get; set; }
        public string? moonrise { get; set; }
        public string? moonset { get; set; }
        public string? moonphase { get; set; }

#pragma warning restore IDE1006 // Naming Styles
    }
}
