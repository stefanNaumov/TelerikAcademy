using System;



class DecimalProgram
{
    static void Main()
    {
        decimal a = 54.2M;
        decimal b = 54.3M;
        bool result = (Math.Round(a, 6)) == (Math.Round(b, 6));
        if (result == true)
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            Console.WriteLine("The numbers are not equal");
        }
    }
}

