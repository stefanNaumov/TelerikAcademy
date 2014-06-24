using System;

class PlusOrMinusOfThreeInts
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number:");
        int c = int.Parse(Console.ReadLine());
        int counting = 1;
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The sign of the product is zero!");
        }
        else
        {
            if (a < 0)
            {
                counting++;
            }
            if (b < 0)
            {
                counting++;
            }
            if (c < 0)
            {
                counting++;
            }
            if (counting == 2 || counting == 4)
            {
                Console.WriteLine("The sign of the product is -");
            }
            else
            {
                Console.WriteLine("The sign of the product is +");
            }
        }
    }
}
