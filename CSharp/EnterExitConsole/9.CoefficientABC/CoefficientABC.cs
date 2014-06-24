using System;

class CoefficientABC
{
    static void Main()
    {
        double coefficientA, coefficientB, coefficientC,discriminant,x1,x2;
        Console.Write("Enter A:");
        coefficientA = double.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        coefficientB = double.Parse(Console.ReadLine());
        Console.Write("Enter C:");
        coefficientC = double.Parse(Console.ReadLine());
        discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientB);
        if (discriminant < 0)
        {
            Console.WriteLine("The equation has no real roots");
        }
        else if ( discriminant == 0 )
        {
            x1 = (-coefficientB) / (coefficientA * coefficientA);
            Console.WriteLine("Discriminant is 0 so equation root x1 is equal to x2: {0}",x1);
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("The equation has two real roots:");
        }
        x1 = (-coefficientB+Math.Sqrt(discriminant))/(coefficientA*coefficientA);
        x2 = (-coefficientB-Math.Sqrt(discriminant))/(coefficientA*coefficientA);
        Console.WriteLine("The root x1 is {0}",x1);
        Console.WriteLine("The root x2 is {0}",x2);
    }
}

