using System.Collections.Generic; 
namespace Api_Cal_lApi.Models{ 

    public class WeekForecastList
    {
        public int dt { get; set; }
        public WeekForecastMain main { get; set; }
        public List<WeekForecastWeather> weather { get; set; }
        public WeekForecastClouds clouds { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
        public double pop { get; set; }
        public WeekForecastRain rain { get; set; }
        public WeekForecastSys sys { get; set; }
        public string dt_txt { get; set; }
    }

}