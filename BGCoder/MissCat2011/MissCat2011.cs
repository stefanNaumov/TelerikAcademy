using System;
using System.Collections.Generic;
using System.Linq;


namespace MissCat
{
    class MissCat2011
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int catOne = 1;
            int catTwo = 2;
            int catThree = 3;
            int catFour = 4;
            int catFive = 5;
            int catSix = 6;
            int catSeven = 7;
            int catEigth = 8;
            int catNine = 9;
            int catTen = 10;
            int countOne = 0;
            int countTwo = 0;
            int countThree = 0;
            int countFour = 0;
            int countFive = 0;
            int countSix = 0;
            int countSeven = 0;
            int countEigth = 0;
            int countNine = 0;
            int countTen = 0;
            if (N > 0 && N <= 100000)
            {
                for (int i = 0; i < N; i++)
			    {
                    int vote = int.Parse(Console.ReadLine());
                    if (vote > 10 || vote < 1)
                    {
                        break;
                    }
                    else if (vote == 1)
                    {
                        countOne++;
                    }
                    else if (vote == 2)
                    {
                        countTwo++;
                    }
                    else if (vote == 3)
                    {
                        countThree++;
                    }
                    else if (vote == 4)
                    {
                        countFour++;
                    }
                    else if (vote == 5)
                    {
                        countFive++;
                    }
                    else if (vote == 6)
                    {
                        countSix++;
                    }
                    else if (vote == 7)
                    {
                        countSeven++;
                    }
                    else if (vote == 8)
                    {
                        countEigth++;
                    }
                    else if (vote == 9)
                    {
                        countNine++;
                    }
                    else if (vote == 10)
                    {
                        countTen++;
                    }
                    vote = 0;
			    }
            }
            int[] cats = new int[] { countOne,countTwo,countThree,countFour,countFive,countSix,countSeven,countEigth,countNine,countTen };
            int max = cats.Max();
            if (max == countOne)
            {
                Console.WriteLine(catOne);
            }
            if (max == countTwo)
            {
                Console.WriteLine(catTwo);
            }
            if (max == countThree)
            {
                Console.WriteLine(catThree);
            }
            if (max == countFour)
            {
                Console.WriteLine(catFour);
            }
            if (max == countFive)
            {
                Console.WriteLine(catFive);
            }
            if (max == countSix)
            {
                Console.WriteLine(catSix);
            }
            if (max == countSeven)
            {
                Console.WriteLine(catSeven);
            }
            if (max == countEigth)
            {
                Console.WriteLine(catEigth);
            }
            if (max == countNine)
            {
                Console.WriteLine(catNine);
            }
            if (max == countTen)
            {
                Console.WriteLine(catTen);
            }
        }
    }
}
