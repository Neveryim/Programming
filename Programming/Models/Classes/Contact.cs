using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Enums
{
    internal class Contact
    {
        private string Name { get; set; }

        private string Surname { get; set; }

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
        private void AssertStringContainsOnlyLetters(string name, string surname )
        {
            for (int i = 0; i < name.Length; ++i)
            {
                if (char.IsLetter(name[i]))
                {
                    Name = name;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящей строкой", name),
                                   "name");
                }
            }
            for (int i = 0; i < surname.Length; ++i)
            {
                if (char.IsLetter(surname[i]))
                {
                    Surname = surname;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящей строкой", surname),
                                   "surname");
                }
            }


        }
    }
}
