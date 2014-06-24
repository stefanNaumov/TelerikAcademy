using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public static class UtilsVolume
    {
        public static double CalcVolume(double width,double height,double depth)
        {
            double volume = width * height * depth;
            return volume;
        }
    }
}
