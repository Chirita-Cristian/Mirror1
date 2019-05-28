using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Forecast
    {
        public city city { get; set; }
        public List<list> list { get; set; }
    }
    public class temp
    {
        public double day { get; set; }
        public double min { get; set; }
        public double night { get; set; }
        public double max { get; set; }
    }
    public class weather
    {
        public string main { get; set; }// conditie
        public string description { get; set; }//descriere
        public string icon { get; set; }//iconita

    }
    public class city
    {
        public string name { get; set; }
    }
    public class list
    {
        public double humidity { get; set; }
        public double speed { get; set; }
        public temp temp { get; set; }
        
        public List<weather> weather { get; set; }
    }
}
