using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Validator
    {
        //проверка на положительное 
        public int AssertOnPositiveValue(int value)
        {
            if(value >= 0)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
        }
        //перегружаем метод
        public double AssertOnPositiveValue(double value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }
        }
        //проверка доступных чисел
        public int AssertValueInRange(int value, int min, int max)
        {
           if (max == 10)
           {
                if (value >= min && value <= max)
                    return value;
                else
                {
                    throw new ArgumentException(String.Format("{0} ошибочный рейтинг"));
                }
           }            
           else if (max == 60 || max == 23) 
           {
                if (value >= min && value <= max)
                    return value;
                else
                {
                    throw new ArgumentException(String.Format("{0} неверный формат времени"));
                }

           }
           else
           {
                throw new ArgumentException(String.Format("{0} неверные числа max min"));
           }
        }
    }

}
