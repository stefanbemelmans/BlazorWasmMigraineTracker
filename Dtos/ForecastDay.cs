using System;
using System.Collections.Generic;

namespace BlazorWasmMigraineTracker.Dtos.Weather
{
  public class Forecast
  {
    public List<ForecastDay> forecastday { get; set; }
  }

  public class ForecastDay
  {
    public string date { get; set; }
    public int date_epoch { get; set; }
    public DayElement day { get; set; }
    public AstroElement astro { get; set; }
    public List<Hour> hour { get; set; }
  }
}
