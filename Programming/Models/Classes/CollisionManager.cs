using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    internal class CollisionManager
    {



        //пресечение прямоугольников
        bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            if((rectangle1.X - rectangle2.X < Math.Abs(rectangle1.Width - rectangle2.Width) / 2)&&(rectangle1.Y - rectangle2.Y < Math.Abs(rectangle1.Height- rectangle2.Height) / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //пересечение окружностей 
        bool IsCollision(Ring ring1, Ring ring2)
        {
            Point2D p1 = ring1.Center();
            Point2D p2 = ring2.Center();
            double gip = Math.Sqrt(Math.Pow((p1.getX() - p2.getX()), 2) + Math.Pow((p1.getY() - p2.getY()), 2));
            if ((ring1.GetR() + ring2.GetR()) <= gip)
            {
                return true;
            }
            else  return false;
        }



    }
}
