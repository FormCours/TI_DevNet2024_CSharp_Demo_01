using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Models
{
    public struct MathHelper
    {
        public double Multi(double nb1, double nb2)
        {
            return Math.Round(nb1, 2)  * Math.Round(nb2, 2);
        }

        public double Multi(double nb1, double nb2, double nb3)
        {
            double res = Multi(nb1, nb2);
            return Multi(res, nb3);
        }

        public double Multi(double nb1, double nb2, double nb3, params double[] nbs)
        {
            double res = Multi(nb1, nb2, nb3);

            foreach(double val in nbs)
            {
                res = Multi(res, val);
            }
            return res;
        }


    }
}
