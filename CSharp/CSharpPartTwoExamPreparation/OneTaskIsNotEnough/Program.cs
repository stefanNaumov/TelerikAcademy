using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int numberOfLamps = int.Parse(Console.ReadLine());
        bool[] lamps = new bool[numberOfLamps];
        int lastPosition = FindLastLamp(lamps);
        Console.WriteLine(lastPosition);
    }
    static int FindLastLamp(bool[] lampsArray)
    {
        int steps = 2;
        int lastPosition = 0;

        while (true)
        {
            int firstLampPosition = SearchForFirstLamp(lampsArray);
            if (firstLampPosition == -1000)
            {
                return lastPosition + 1;
            }
            else
            {
                while (true)
                {
                    if (lampsArray[firstLampPosition] == false)
                    {
                        lampsArray[firstLampPosition] = true;
                        lastPosition = firstLampPosition; 
                    }
                    firstLampPosition += steps;

                    if (firstLampPosition > lampsArray.Length - 1)
                    {
                        steps++;
                        break;
                    }
                } 
            }
        }
    }
    static int SearchForFirstLamp(bool[] street)
    {
        int firstLamp = -1000;
        for (int i = 0; i < street.Length; i++)
        {
            if (street[i] == false)
            {
                firstLamp = i;
                break;
            }
        }
        return firstLamp;
    }
}

