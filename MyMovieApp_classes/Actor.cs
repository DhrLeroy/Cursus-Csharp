using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMovieApp_classes
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime Birthday { get; set; }

        public int BepaalLeeftijd()
        {
            return Convert.ToInt32((DateTime.Now - Birthday).TotalDays / 365.25);
        }
    }
}
