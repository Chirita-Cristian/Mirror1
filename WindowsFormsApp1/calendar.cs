using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class calendar
    {
        public List<items> items { get; set; }
       
    }
    public class items
    {
        public string summary { get; set; }
        public string location { get; set; }
        public start start { get; set; }
        public class stop
        {
            public string dateTime { get; set; }
        }
        
    }
    public class start
    {
        public string dateTime { get; set; }
    }
}

