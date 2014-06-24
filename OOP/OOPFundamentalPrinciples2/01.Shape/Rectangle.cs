﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle: Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
