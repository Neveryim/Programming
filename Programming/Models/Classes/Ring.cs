using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Classes
{
    internal class Ring
    {
        private int iside_r { get; set; }
        private int external_R { get; set; }

        private int x { get; set; }
        private int y { get; set; }
        public Ring(int s_r, int b_r)
        {

            Check(s_r, b_r);
            Aera(s_r,b_r);
        
        }
        private void Check(int  s_r, int b_r)
        {
            Validator vd = new Validator();
            iside_r =  vd.AssertValueInRange(vd.AssertOnPositiveValue(s_r),1,b_r);
            external_R = vd.AssertValueInRange(vd.AssertOnPositiveValue(b_r),s_r,200);
        }
        private double Aera(int s_r, int b_r)
        {
            return Math.PI * b_r - Math.PI * s_r;
        }
        public Point2D Center()
        {

            int w_center = (int)x;
            int h_center = (int)y;

            return new Point2D(w_center, h_center);
        }
        public int GetR()
        {
            return external_R;
        }
    }

}
