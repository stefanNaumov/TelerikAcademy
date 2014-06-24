using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        public static Point3D staticPoint = new Point3D(0, 0, 0);
        private int x;
        private int y;
        private int z;

        public Point3D(int x, int y, int z)
            :this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        int integer;
        public int PointX
        {
            get { return this.x; }
            set
            {
                if (!(int.TryParse(value.ToString(),out integer)))
                {
                    throw new ArgumentException("Value must be a integer!");
                }
                this.x = value;
            }
        }
		
        public int PointY
        {
            get { return this.y; }
            set
            {
                if (!(int.TryParse(value.ToString(),out integer)))
                {
                    throw new ArgumentException("Value must be a integer!");
                }
                this.y = value;
            }
        }
		
        public int PointZ
        {
            get { return this.z; }
            set
            {
                if (!(int.TryParse(value.ToString(),out integer)))
                {
                    throw new ArgumentException("Value must be a integer!");
                }
                this.z = value;
            }
        }
		
        public override string ToString()
        {
            StringBuilder pointsToStr = new StringBuilder();
            pointsToStr.AppendFormat("{0},{1},{2}", x,y,z);
            return pointsToStr.ToString();
        }
    }
}
