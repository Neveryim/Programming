using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    internal class Time
    {
        private int Watch { get; set; }

        private int Minutes { get; set; }

        private int Seconds { get; set; }

        //реализуем класс
        public Time(int watch, int min, int sec)
        {

            Check(watch, min, sec);


        }
        //проверяем условия
        private void Check(int watch, int min, int sec)
        {
            if (watch >= 0 & watch <= 23 & min >= 0 & min <= 60 & sec >= 0 & sec <= 60)
            {
                Watch = watch;
                Minutes = min;
                Seconds = sec;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));

            }
        }
    }
}
