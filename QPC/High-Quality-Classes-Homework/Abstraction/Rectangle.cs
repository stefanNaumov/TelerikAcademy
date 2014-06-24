using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double width;
        private double height;
        public Rectangle()
        {
            this.Width = 0;
            this.Height = 0;
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get { return this.width; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Width cannot be null!");
                }
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative number!");
                }
                this.width = value; 
            }
        }
        public double Height
        {
            get { return this.height; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Height cannot be null!");
                }
                if (value < 0 )
                {
                    throw new ArgumentException("Height cannot be negative number!");
                }
                this.height = value; 
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
