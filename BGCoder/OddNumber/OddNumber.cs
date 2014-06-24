using System;
using System.Collections.Generic;


namespace OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            //int N = int.Parse(Console.ReadLine());
            int[] arr = new int[]{2,-1,2};
            int positionCount = 0;
            int currentPosition = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    arr[i] = number;
            //}
            if (arr.Length < 2)
            {
                currentPosition = arr[0];
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int inner = i + 1; inner < arr.Length - 1; inner++)
                    {

                        if (!(arr[i] == arr[inner]))
                        {
                            positionCount++;
                            currentPosition = arr[inner];
                        }
                    }
                    positionCount = 0;
                }
            }
            Console.WriteLine(currentPosition);
        }
    }
}
