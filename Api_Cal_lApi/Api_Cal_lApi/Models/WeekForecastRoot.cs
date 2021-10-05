using System.Collections.Generic; 
namespace Api_Cal_lApi.Models{ 

    public class WeekForecastRoot
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<WeekForecastList> list { get; set; }
        public WeekForecastCity city { get; set; }
    }

}