using System;

//09.In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:

//And

//10.Write a program to calculate the Nth Catalan number by given N.






class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number N to be calculated in Catalan's formula: ");
        double N = double.Parse(Console.ReadLine());
        double firstFactorial = N * N;
        double secondFactorial = N + 1;
        double thirdFactorial = N;
        double resultOne = 1;
        double resultTwo = 1;
        double resultThree = 1;
        if (N > 0)
        {
            for (double i = firstFactorial; i >= 1; i--)
            {
                resultOne *= i;
            }
            for (double i2 = secondFactorial; i2 >= 1; i2--)
            {
                resultTwo *= i2;
            }
            for (double i3 = thirdFactorial; i3 >= 1; i3--)
            {
                resultThree *= i3;
            }
            Console.Write("The result is :");
            Console.Write("{0}/{1}*{2} = ", resultOne, resultTwo, resultThree);
            double final = (resultOne / (resultTwo * resultThree));
            Console.WriteLine(final);
        }
        else
        {
            Console.WriteLine("N must be bigger than 0!");
        }
    }
}

