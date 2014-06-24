using System;

class ExercisePrimeNToM
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter m:");
        double m = double.Parse(Console.ReadLine());
        if ((n > 1) && (m > n))
        {
            for (double num = n; num < m; num++)
            {
                bool loop = true;
                double divider = 2;
                double MaxDivider = Math.Sqrt(num);
                while (divider <= MaxDivider)
                {
                    if (num % divider == 0)
                    {
                        loop = false;
                        break;
                    }
                    divider++;
                }
                if (loop)
                {
                    Console.Write(" " + num + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("n must be smaller than m and greater than one!!!");
        }
    }   
}

