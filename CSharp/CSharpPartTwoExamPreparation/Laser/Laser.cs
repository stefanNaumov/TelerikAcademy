using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Laser
{
    static void Main()
    {
        string[] dimensionNums = "5 10 5".Split(' ');
        int[] dimensions = GetThreeNumbers(dimensionNums);
        string[] positionNums = "2 6 3".Split(' ');
        int[] positions = GetThreeNumbers(positionNums);
        string[] vectorNums = "1 0 1".Split(' ');
        int[] vectors = GetThreeNumbers(vectorNums);

        bool[,,] visited = new bool[dimensions[0]+1,dimensions[1]+1,dimensions[2]+1];

        while (true)
        {
            visited[positions[0], positions[1], positions[2]] = true;

            int[] newPos = new int[3];

            for (int i = 0; i < 3; i++)
            {
                newPos[i] = positions[i] + vectors[i];
            }
            if(visited[newPos[0],newPos[1],newPos[2]] == true)
            {
                Console.WriteLine("{0} {1} {2}",positions[0],positions[1],positions[2]);
                return;
            }

        }
    }
    static int[] GetThreeNumbers(string[] values)
    {
        
        return values.Select(e => int.Parse(e)).ToArray();
    }
}

