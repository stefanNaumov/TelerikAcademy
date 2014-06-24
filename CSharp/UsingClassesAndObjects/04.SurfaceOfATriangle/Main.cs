using System;
using System.Collections.Generic;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.



class SurfaceOfATriangle
{
    static void Main()
    {
        int sideAndAltitude = Triangle.SurfaceBySideAndAltitude();
        Console.WriteLine("The surface of the triangle by given side and altitude is: {0}", sideAndAltitude);

        int threeSides = Triangle.SurfaceByThreeSides();
        Console.WriteLine("The surface of the triangle by given three sides and is: {0}", threeSides);

        int twoSidesAndAngle = Triangle.SurfaceByTwoSidesAndAngle();
        Console.WriteLine("the surface of the triangle by given two sides and angle is: {0}", twoSidesAndAngle);

    }
}

