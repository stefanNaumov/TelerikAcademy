using System;


namespace TelerikLogo
{
    class TelerikLogo
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            
            Console.Write(new string('.',x/2));
            Console.Write('*');
            Console.Write(new string('.',(x*2)-3));
            Console.Write('*');
            Console.Write(new string('.',x/2));
            Console.WriteLine();
            
            int dotsLeft = (x / 2) - 1;
            int dotsRight = 1;
            int dotsMiddle = (x * 2) - 5;
            for (int i = 0; i < x/2; i++)
            {
                Console.Write(new string('.',dotsLeft));
                Console.Write('*');
                Console.Write(new string('.',dotsRight));
                Console.Write('*');
                Console.Write(new string('.',dotsMiddle));
                Console.Write('*');
                Console.Write(new string('.',dotsRight));
                Console.Write('*');
                Console.Write(new string('.',dotsLeft));
                Console.WriteLine();
                dotsLeft--;
                dotsRight += 2;
                dotsMiddle -= 2;
            }
            for (int i = 0; i < x/2-1; i++)
            {
                Console.Write(new string('.', dotsRight));
                Console.Write('*');
                Console.Write(new string('.', dotsMiddle));
                Console.Write('*');
                Console.Write(new string('.', dotsRight));
                Console.WriteLine();
                dotsRight++;
                dotsMiddle -= 2;
            }
            Console.Write(new string('.', dotsRight));
            Console.Write('*');
            Console.Write(new string('.', dotsRight));
            Console.WriteLine();
            int mid = 1;
            dotsRight--;

            for (int i = 0; i < x - 1; i++)
            {
                Console.Write(new string('.', dotsRight));
                Console.Write('*');
                Console.Write(new string('.', mid));
                Console.Write('*');
                Console.Write(new string('.', dotsRight));
                Console.WriteLine();
                mid += 2;
                dotsRight--;
            }
            dotsRight = (x / 2) + 1;
            mid = (x * 2) - 5;
            for (int i = 0; i < x - 2 ; i++)
            {

                Console.Write(new string('.', dotsRight));
                Console.Write('*');
                Console.Write(new string('.', mid));
                Console.Write('*');
                Console.Write(new string('.', dotsRight));
                Console.WriteLine();
                dotsRight++;
                mid -= 2;
            }
            Console.Write(new string('.', dotsRight));
            Console.Write('*');
            Console.Write(new string('.', dotsRight));
            Console.WriteLine();
        }
    }
}
