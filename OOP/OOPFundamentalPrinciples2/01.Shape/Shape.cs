using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        private double width;
        private double height;
        protected Shape(double width, double height)
        {
            if (width <= 0.0)
            {
                throw new ArgumentException("Width cannot be negative!");
            }
            if (height <= 0.0)
            {
                throw new ArgumentException("Height cannot be negative!");
            }
            this.width = width;
            this.height = height;
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Width cannot be negative!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (height <= 0.0)
                {
                    throw new ArgumentException("Height cannot be negative!");
                }
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
    }
}
