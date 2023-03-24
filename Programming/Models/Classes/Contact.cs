using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Enums
{
    internal class Contact
    {
        private string Name { get; set; }

        private int Number { get; set; }

        private string Address { get; set; }

        private string Post { get; set; }

        public Contact(string name, int number, string adress, string post)
        {

            Name = name;
            Address = adress;
            Post = post;
            Check(number);


        }
        private void Check(int number)
        {

            if (number.ToString().Length == 10)
            {

                Number = number;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", number),
                                    "number");
            }


        }
    }
}
