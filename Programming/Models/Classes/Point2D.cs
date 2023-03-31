using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    class Point2D
    {
        private double x;
        private double y;

        public Point2D()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double getX() {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public string PrintCenter()
        {
            return $"{x};{y}";
        }
    }
}
