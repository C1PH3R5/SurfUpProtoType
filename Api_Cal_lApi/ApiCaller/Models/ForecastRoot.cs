using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCaller.Models
{
    public class ForecastRoot
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<ForecastList> list { get; set; }
        public ForecastCity city { get; set; }
    }
}
