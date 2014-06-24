using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    class Program
    {
        static void Main()
        {
            
            //string listOfNumbers = "-2,-1,-4,-3";
            //int percentage = 50;
            //string[] listofNumbersArr = listOfNumbers.Split(',');
            //int[] listOfInts = new int[listofNumbersArr.Length];
            //for (int i = 0; i < listofNumbersArr.Length; i++)
            //{
            //    listOfInts[i] = int.Parse(listofNumbersArr[i]);
            //}
            //Array.Sort(listOfInts);

            //int result = listOfInts[(percentage * listofNumbersArr.Length - 1) / 100];
            //Console.WriteLine(result);
            int[, ,] cube = new int[3, 2, 4];
            int count = 1;
            for (int h = 0; h < cube.GetLength(0); h++)
            {
                for (int d = 0; d < cube.GetLength(1); d++)
                {
                    for (int w= 0; w < cube.GetLength(2); w++)
                    {
                        cube[h, d, w] = count;
                        count++;
                    }   
                }
            }
        }
    }
}
