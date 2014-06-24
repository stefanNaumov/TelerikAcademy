using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main()
        {
            Triangle triangle = new Triangle(3.5, 8.2);
            Rectangle rectangle = new Rectangle(3.5, 8.2);
            Circle circle = new Circle(3.1);
            Console.WriteLine("Triangle with width: {0} and height: {1} has surface: {2}",triangle.Width,triangle.Height,triangle.CalculateSurface());
            Console.WriteLine("Rectangle with width: {0} and height: {1} has surface: {2}", rectangle.Width, rectangle.Height, rectangle.CalculateSurface());
            Console.WriteLine("Circle with radius {0} has surface: {1}",circle.Width,circle.CalculateSurface());
        }
    }
}
