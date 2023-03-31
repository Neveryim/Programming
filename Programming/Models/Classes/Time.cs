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
            Validator vd = new Validator();
            try
            {
                Watch = vd.AssertValueInRange(vd.AssertOnPositiveValue(watch), 1, 24);
                Minutes = vd.AssertValueInRange(vd.AssertOnPositiveValue(min), 1, 60);
                Seconds = vd.AssertValueInRange(vd.AssertOnPositiveValue(sec), 1, 60);
            }
            catch
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
                
                 
        }
    }
}
