using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class Distance3D
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance;
            distance = Math.Sqrt(((firstPoint.PointX - secondPoint.PointX) * (firstPoint.PointX - secondPoint.PointX))
                                + ((firstPoint.PointY - secondPoint.PointY) * (firstPoint.PointY - secondPoint.PointY))
                                + ((firstPoint.PointZ - secondPoint.PointZ) * (firstPoint.PointZ - secondPoint.PointZ)));
            return distance;
        }
    }
}
