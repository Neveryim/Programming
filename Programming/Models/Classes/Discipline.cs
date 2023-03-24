using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Enums
{
    internal class Discipline
    {
        private string Title { get; set; }
        private int Number_of_hours { get; set; }

        private int Scores { get; set; }

        public Discipline(string title, int number, int scores)
        {

            Title = title;


        }
        private void Check(int number, int scores)
        {

            if (number > 0 & scores > 0)
            {

                Number_of_hours = number;
                Scores = scores;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом"));
            }


        }
    }
}
