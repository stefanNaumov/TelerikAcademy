using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_ZagLines
{
    class Program
    {
        static HashSet<string> combinations = new HashSet<string>();
        static bool[] used;

        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(' ');

            int N = int.Parse(inputLine[0]);
            int K = int.Parse(inputLine[1]);

            used = new bool[N];
            int[] currComb = new int[K];
            GetCombinations(N, K, 0, currComb);

            Console.WriteLine(combinations.Count);
        }

        static void GetCombinations(int N, int K, int index, int[] currComb)
        {
            if (index >= K)
            {
                if (IsZigZag(currComb))
                {
                    var combToStr = string.Join("", currComb);
                    combinations.Add(combToStr);
                }
                
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (!used[i])
                {
                    currComb[index] = i;
                    used[i] = true;
                    GetCombinations(N, K, index + 1, currComb);
                    used[i] = false;
                }
                
            }
        }

        static bool IsZigZag(int[] combination)
        {

            bool isZigZag = true;
            if (combination.Length == 1)
            {
                return true;
            }
            else if (combination.Length == 2)
            {
                return combination[0] > combination[1];
            }
            else
            {
                for (int i = 1; i < combination.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        var odd = combination[i] < combination[i - 1] && combination[i] < combination[i + 1];

                        if (!odd)
                        {
                            isZigZag = false;
                            break;
                        }
                    }
                    else
                    {
                        var even = combination[i] > combination[i - 1] && combination[i] > combination[i + 1];

                        if (!even)
                        {
                            isZigZag = false;
                            break;
                        }
                    }
                } 
            }

            return isZigZag;
        }
    }
}
