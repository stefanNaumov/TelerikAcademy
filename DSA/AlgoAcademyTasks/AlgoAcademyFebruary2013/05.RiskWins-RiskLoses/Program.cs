using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskWins_RiskLoses
{
    class Program
    {
        const int MaxComb = 99999;
        static int wordsCount = 5;
        static bool[] forbiddenCombs = new bool[MaxComb + 1];
        static bool[] usedCombs = new bool[MaxComb + 1];

        static void Main()
        {
            int startComb = int.Parse(Console.ReadLine());

            int targetComb = int.Parse(Console.ReadLine());

            int forbiddenCombsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < forbiddenCombsCount; i++)
            {
                int currComb = int.Parse(Console.ReadLine());

                forbiddenCombs[currComb] = true;
            }

            int steps = FindCombination(startComb, targetComb);

            Console.WriteLine(steps);
        }

        static int FindCombination(int startComb, int targetComb)
        {
            int[] powerOften = new int[wordsCount];
            int power = 1;
            powerOften[0] = power;

            for (int i = 1; i < wordsCount; i++)
            {
                powerOften[i] = powerOften[i - 1] * 10;
            }

            int level = 0;

            Queue<int> nodes = new Queue<int>();

            nodes.Enqueue(startComb);

            while (nodes.Count > 0)
            {
                Queue<int> nextLevelNodes = new Queue<int>();
                level++;

                while (nodes.Count > 0)
                {
                    int node = nodes.Dequeue();

                    if (node == targetComb)
                    {
                        return level - 1;
                    }

                    //go left
                    for (int i = 0; i < wordsCount; i++)
                    {
                        int newNode = node;

                        int digit = (newNode / powerOften[i]) % 10;

                        //TODO:Fix
                        if (digit == 9)
                        {
                            newNode -=  9 * powerOften[i];
                        }
                        else
                        {
                            newNode += powerOften[i];
                        }
                        
                        if (!usedCombs[newNode] && !forbiddenCombs[newNode])
                        {
                            nextLevelNodes.Enqueue(newNode);
                            usedCombs[newNode] = true;
                        }
                    }

                    //go right
                    for (int i = 0; i < wordsCount; i++)
                    {
                        int newNode = node;

                        int digit = (newNode / powerOften[i]) % 10;

                        
                        if (digit == 0)
                        {
                            newNode += 9 * powerOften[i];
                        }
                        else
                        {
                            newNode -= powerOften[i];
                        }

                        if (!usedCombs[newNode] && !forbiddenCombs[newNode])
                        {
                            nextLevelNodes.Enqueue(newNode);
                            usedCombs[newNode] = true;
                        }
                        
                    }
                }

                nodes = nextLevelNodes;
            }

            return -1;
        }
    }
}
