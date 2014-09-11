using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.InaBoyfriend
{
    class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            string[] names = new string[matrixSize];
            int[] values = new int[matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string[] currLine = Console.ReadLine().Split(' ');
                string name = currLine[0];

                names[i] = name;
                string currLikes = currLine[1];
                for (int j = 0; j < currLikes.Length; j++)
                {
                    int like = int.Parse(currLikes[j].ToString());
                    values[i] += like;
                }
            }
            int maxLikes = 0;
            string maxName = names[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > maxLikes)
                {
                    maxLikes = values[i];
                    maxName = names[i];
                }
            }

            Console.WriteLine(maxName);
        }
    }
}
