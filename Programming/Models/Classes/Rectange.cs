using Programming.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Programming.Models.Enums
{
    internal class Rectangles
    {
        private string _name { get; set; }
        private double Width { get; set; }
        private double Height { get; set; }

        private string Color { get; set; }
        private int Id = 0;
        private static int _allRectanglesCount = 0;

        public Rectangles(double height,double width, string color,int id)
        {
           
            Check(width, height);
            Color = color;
            Id = id;
        }
        public Rectangles() {
            _allRectanglesCount +=1;
        }

        //проверяем условия 
        private void Check(double width, double height)
        {
          Validator vd = new Validator();
          Width = vd.AssertOnPositiveValue(width);
          Height = vd.AssertOnPositiveValue(height);
        }
        //получаем значение
        public string[] answRec()
        {
            string[] answ = {Height.ToString(), Width.ToString(), Color,Id.ToString() };
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
        public Point2D Center()
        {

            int w_center = (int)Width/2;
            int h_center = (int)Height/2;

            return new Point2D(w_center, h_center);
        }
        public static int AllRectanglesCount() 
        {
            return _allRectanglesCount;
        }
    }
}
