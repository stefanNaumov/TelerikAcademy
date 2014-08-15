using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrying
{
    class Program
    {
        static void Main()
        {
            int bagCapacity = int.Parse(Console.ReadLine());

            int numberOfRooms = int.Parse(Console.ReadLine());

            string[] roomTreasures = Console.ReadLine().Split(' ');

            int maxRooms = 0;
            int currentSum = 0;
            int counter = 0;

            for (int i = 0; i < numberOfRooms; i++)
            {
                int currRoomVal = int.Parse(roomTreasures[i]);

                if (currentSum + currRoomVal > bagCapacity)
                {
                    break;
                }
                else
                {
                    counter++;
                    currentSum += currRoomVal;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
