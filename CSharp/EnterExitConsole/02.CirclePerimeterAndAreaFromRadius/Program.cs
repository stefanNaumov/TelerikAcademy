using System;


//Write a program that reads the radius r of a circle and prints its perimeter and area.


namespace _02.CirclePerimeterAndAreaFromRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = (2 * radius) * Math.PI;
            double area = Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine("Perimeter:{0}  Area{1}",perimeter,area);

            
        }
    }
}
