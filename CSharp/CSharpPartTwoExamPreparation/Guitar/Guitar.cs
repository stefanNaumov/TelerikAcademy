using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Guitar
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[]{',', ' '},StringSplitOptions.RemoveEmptyEntries);
        int initialVolumeB = int.Parse(Console.ReadLine());
        int maxVolumeM = int.Parse(Console.ReadLine());

        int[] numsToint = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numsToint[i] = int.Parse(numbers[i]);
        }

    }
}

