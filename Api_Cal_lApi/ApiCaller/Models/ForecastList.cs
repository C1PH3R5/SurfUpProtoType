using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCaller.Models
{
    public class ForecastList
    {
        public int dt { get; set; }
        public ForecastMain main { get; set; }
        public List<ForecastWeather> weather { get; set; }
        public ForecastClouds clouds { get; set; }
        public ForecastWind wind { get; set; }
        public int visibility { get; set; }
        public double pop { get; set; }
        public ForecastRain rain { get; set; }
        public ForecastSys sys { get; set; }
        public string dt_txt { get; set; }
    }
}
