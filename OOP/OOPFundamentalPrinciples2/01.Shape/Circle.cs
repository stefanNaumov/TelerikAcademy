using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle: Shape
    {
        public Circle(double radius):base(radius,radius)
        {
            
        }
        public override double CalculateSurface()
        {
            return (this.Height * this.Height) * Math.PI;
        }
    }
}
