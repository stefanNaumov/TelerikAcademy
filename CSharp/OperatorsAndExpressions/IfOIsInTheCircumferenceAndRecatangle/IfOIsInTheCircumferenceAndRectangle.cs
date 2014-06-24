using System;


class IfOIsInTheCircumferenceAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter value for X:");
        double XCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for Y");
        double YCoordinate = double.Parse(Console.ReadLine());
        bool resultCircumference = (XCoordinate) * (XCoordinate) + (YCoordinate) * (YCoordinate) <= (5 * 5);
        if
            (resultCircumference == true)
            Console.WriteLine("The point is within the Circumference");
        else
            Console.WriteLine("The point is outside the Circumference");
        bool Rectangle = ((XCoordinate <= -1) || (XCoordinate >= 5) || (YCoordinate <= -1) || (YCoordinate >= 1));
        if
            (Rectangle==true)
            Console.WriteLine("The point is outside the Rectangle");
        else
            Console.WriteLine("The point is within the Rectangle");
    }
}

