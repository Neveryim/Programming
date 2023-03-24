using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Enums
{
    internal class Rectange
    {
        private string _name { get; set; }
        private double Width { get; set; }
        private double Height { get; set; }

        private string Color { get; set; }


        public Rectange(double width, double height, string color)
        {

            Check(width, height);
            Color = color;
        }
        public Rectange() { }

        //проверяем условия 
        private void Check(double width, double height)
        {
            if (width > 0.0 & height > 0.0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} не является подходящим числом", width),
                                      "width");
            }
        }
        //получаем значение
        public string[] answRec()
        {
            string[] answ = { _name, Width.ToString(), Height.ToString(), Color };
            return answ;
        }
        //смена значений
        public void Chenge(double width, double height, string color)
        {
            Check(width, height);
            Color = color;

        }
        public int getWith()
        {

            return (int)Width;
        }
    }
}
