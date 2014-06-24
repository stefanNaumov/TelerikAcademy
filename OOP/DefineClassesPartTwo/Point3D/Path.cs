using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        private List<Point3D> pointsList = new List<Point3D>();

        public void AddPath(Point3D currentPoint)
        {
            this.pointsList.Add(currentPoint);
        }
        public List<Point3D> PathList
        {
            get { return this.pointsList; }
        }
    }
}
