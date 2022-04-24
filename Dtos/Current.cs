namespace BlazorWasmMigraineTracker.Dtos.Weather
{
  public class Current 
  {
    public int cloud { get; set; }
    public Condition condition { get; set; }
    public decimal feelslike_c { get; set; }
    public decimal feelslike_f { get; set; }
    public decimal gust_kph { get; set; }
    public decimal gust_mph { get; set; }
    public int humidity { get; set; }
    public int is_day { get; set; }
    public string last_updated { get; set; }
    public int last_updated_epoch { get; set; }
    public decimal precip_in { get; set; }
    public decimal precip_mm { get; set; }
    public decimal pressure_in { get; set; }
    public decimal pressure_mb { get; set; }
    public decimal temp_c { get; set; }
    public decimal temp_f { get; set; }
    public decimal uv { get; set; } // uv index
    public int wind_degree { get; set; }
    public string wind_dir { get; set; }
    public decimal wind_kph { get; set; }
    public decimal wind_mph { get; set; }
    //1 = yes, 0 = no
  }
}
