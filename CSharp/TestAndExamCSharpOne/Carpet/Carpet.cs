using System;

namespace Carpet
{
    class Carpet
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int dots = (N / 2) - 1;
            string leftSide = "/";
            string rightSide = "\\";
            int stringLength;

            Console.Write(new string('.', dots));
            Console.Write(leftSide);
            Console.Write(rightSide);
            Console.Write(new string('.', dots));
            Console.WriteLine();
            dots--;

            

            for (int i = 0; i < (N / 2)-1 ; i++)
			{
                if (i % 2 == 0)
                {
                    Console.Write(new string('.',dots)+ leftSide + new string(' ',2) + rightSide + new string('.',dots));
                    dots--;
                }
                
                else 
                {
                    leftSide = leftSide + " /";
                    rightSide = rightSide + " \\";
                    Console.Write(new string('.',dots) + leftSide + rightSide);
                    dots--;
                }
                Console.WriteLine();
			}
            dots = 0;

            for (int i = 1; i < N / 2; i++)
            {
                if (i % 2 != 0)
                {
                    rightSide = "\\ ";
                    leftSide = " /";
                    Console.Write(new string('.',dots) + rightSide + leftSide + new string('.',dots));
                    dots++;
                }
                else
                {
                    rightSide = "\\ \\";
                    leftSide = "/ /";
                    Console.Write(new string('.', dots) + rightSide + new string(' ', 2) + leftSide + new string('.', dots));
                    dots++;
                    //stringLength = leftSide.Length;
                    //leftSide = leftSide.Remove(stringLength - 2, 2);

                    //stringLength = rightSide.Length;
                    //rightSide = rightSide.Remove(stringLength - 2, 2);
                    Console.WriteLine();
                }


            }
            
     


            






                //int blankSpace = 2;
                //Console.Write(new string('.', leftDots));
                //Console.Write('/');
                //Console.Write(new string(' ', blankSpace));
                //Console.Write('\\');
                //Console.Write(new string('.', rightDots));
                //Console.WriteLine();

                //for (int i = 2; i < N / 2; i++)
                //{
                //    leftDots--;
                //    rightDots--;
                //    Console.Write(new string('.',leftDots));
                //    Console.Write('/');

                //}







            //int blankSpace = N - ((leftDots + rightDots) + 2);
            //Console.Write(new string('.',leftDots));
            //Console.Write('/');
            //Console.Write(new string(' ',blankSpace));
            //Console.Write('\\');
            //Console.Write(new string('.',rightDots));
            //Console.WriteLine();
            //leftDots--;
            //rightDots--;
            //Console.Write(new string('.',leftDots));
            //Console.Write('/');
            //Console.Write(new string(' ',blankSpace/2));
            //Console.Write('/');
            //Console.Write('\\');
            //Console.Write(new string(' ',blankSpace/2));
            //Console.Write('\\');
            //Console.Write(new string('.',rightDots));
        }
    }
}
