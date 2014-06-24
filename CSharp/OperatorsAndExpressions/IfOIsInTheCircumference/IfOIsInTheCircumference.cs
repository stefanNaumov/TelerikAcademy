using System;


class IfOIsInTheCircumference
{
    static void Main()
    {
        Console.WriteLine("Please enter value for X-axis:");
        decimal XCircumference = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please enter valie for Y-axis");
        decimal YCircumference = Convert.ToDecimal(Console.ReadLine());
        bool resultCircumference = (XCircumference) * (XCircumference) + (YCircumference) * (YCircumference) <= (5 * 5);
        if
            (resultCircumference == true)
            Console.WriteLine("The O-point is within the Circumference");
        else
            Console.WriteLine("The O-point is outside the Circumference");
    }
}

