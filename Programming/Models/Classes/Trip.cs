using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    internal class Trip
    {

        private string Departure_Point { get; set; }
        private string Destination { get; set; }
        private int Flight_time { get; set; }

        public Trip(string dp, string ds, int time)
        {
            Departure_Point = dp;
            Destination = ds;
            Flight_time = time;
        }
        //проверяем условия 
        private void Check(int time)
        {
            if (time <= 0.0)
            {
                Flight_time = time;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", time),
                                      "time");
            }
        }
    }
}
