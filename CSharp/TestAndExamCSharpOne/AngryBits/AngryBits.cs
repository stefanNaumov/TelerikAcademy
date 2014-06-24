using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBits
{
    class AngryBits
    {
        static void Main()
        {
            //ushort zero = ushort.Parse(Console.ReadLine());
            //ushort first = ushort.Parse(Console.ReadLine());
            //ushort second = ushort.Parse(Console.ReadLine());
            //ushort third = ushort.Parse(Console.ReadLine());
            //ushort fourth = ushort.Parse(Console.ReadLine());
            //ushort fifth = ushort.Parse(Console.ReadLine());
            //ushort sixth = ushort.Parse(Console.ReadLine());
            //ushort seventh = ushort.Parse(Console.ReadLine());

            int[,] matrix = new int[8, 16];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                ushort bit = ushort.Parse(Console.ReadLine());
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (bit >> (matrix.GetLength(1) - col)-1) & 1;
                }
            }
            
            
            

            
            
            
            
            
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
