using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvenSecure_DARPA_CFT_2013
{
    // this is not working to my satisfaction
    class gengaussian
    {
        private static bool uselast = true;
        private static double next_gaussian = 0.0;
        private static Random random = new Random();

        public static double BoxMuller()
        {
            if (uselast)
            {
                uselast = false;
                return next_gaussian;
            }
            else
            {
                double v1, v2, s;
                do
                {
                    v1 = 2.0 * random.NextDouble() - 1.0;
                    v2 = 2.0 * random.NextDouble() - 1.0;
                    s = v1 * v1 + v2 * v2;
                } while (s >= 1.0 || s == 0);

                s = System.Math.Sqrt((-2.0 * System.Math.Log(s)) / s);

                next_gaussian = v2 * s;
                uselast = true;
                return v1 * s;
            }
        }

        public static double BoxMuller(double mean, double standard_deviation, double low, double high)
        {
            double retval = double.NaN;
//            int breaker = 0;
            
            retval = mean + BoxMuller() * standard_deviation;

            return retval;
        }
    }
}
