using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sizes = "1,2,3,4,5,6,7,8,9";// Console.ReadLine();
            //int F = 5;//int.Parse(Console.ReadLine());
            //string[] sizesArr = sizes.Split(',');
            //Array.Sort(sizesArr);

            //int myCakes = int.Parse(sizesArr[sizesArr.Length - 1]);
            //Array.Reverse(sizesArr);

            //for (int i = F+1; i < sizesArr.Length; i += F+1)
            //{
            //    myCakes += int.Parse(sizesArr[i]);
            //}
            
            //Console.WriteLine(myCakes);
            //Console.WriteLine("Enter two integers: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a > b)
            //{
            //    a = a ^ b;
            //    b = b ^ a;
            //    a = a ^ b;
            //}
            //Console.WriteLine("First number :{0} , Second number : {1}", a, b);
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[numberOfRows][];
            ReadJaggedArray(jagged);
            int bestValue = 0;
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if(Math.Abs(jagged[i][j]) > bestValue)
                    {
                        bestValue = Math.Abs(jagged[i][j]);
                    }
                }
            }
            Console.WriteLine(bestValue + 1);
        }
        private static int[][] ReadJaggedArray(int[][] rows)
        {
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] currentRow = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                rows[i] = new int[currentRow.Length];

                for (int j = 0; j < currentRow.Length; j++)
                {
                    rows[i][j] = int.Parse(currentRow[j]);
                }
            }
            return rows;
        }
    }
}
