using System;
using System.Collections.Generic;




class Triangle
{
    public static int SurfaceBySideAndAltitude()
    {
        Console.Write("Enter side: ");
        int side = int.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        int altitude = int.Parse(Console.ReadLine());
        int surface;
        surface = (side * altitude) / 2;
        return surface;
    }
    public static int SurfaceByThreeSides()
    {
        Console.Write("Enter side a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter side c: ");
        int c = int.Parse(Console.ReadLine());
        int surface = ((a * b) * (a * c)) / 2;
        return surface;
    }
    public static int SurfaceByTwoSidesAndAngle()
    {
        Console.Write("Enter side a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        int y = int.Parse(Console.ReadLine());
        int surface;
        surface = ((a * b) * (int)Math.Sin(y)) / 2;
        return surface;
    }
}

