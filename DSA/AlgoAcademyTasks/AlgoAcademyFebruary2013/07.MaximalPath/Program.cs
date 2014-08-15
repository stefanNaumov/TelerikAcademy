using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaximalPath
{
    class Program
    {

        public static long maxSumValue;
        static void Main()
        {
            Tree tree = new Tree();
            tree.ParseInput();
            tree.GetMaxSum();

            Console.WriteLine(maxSumValue);
        }

        class Tree
        {
            private Dictionary<int,List<int>> adjacent;
            private HashSet<int> leaves;
            private HashSet<int> parents;
            private HashSet<int> usedNodes;

            public Tree()
            {
                adjacent = new Dictionary<int, List<int>>();
                leaves = new HashSet<int>();
                parents = new HashSet<int>();
                usedNodes = new HashSet<int>();
                maxSumValue = long.MinValue;
            }

            public void ParseInput()
            {
                int N = int.Parse(Console.ReadLine());

                for (int i = 0; i < N - 1; i++)
                {
                    string[] currConnection = Console.ReadLine().Split(new char[] { '(', '<', '-', ')' },StringSplitOptions.RemoveEmptyEntries);

                    int parent = int.Parse(currConnection[0]);
                    int child = int.Parse(currConnection[1]);

                    parents.Add(parent);
                    leaves.Add(child);
                    leaves.Remove(parent);
                    AddConnections(parent, child);
                }
            }
            
            public void GetMaxSum()
            {
                foreach (var leaf in leaves)
                {
                    usedNodes.Clear();
                    DFS(leaf, 0);
                }
            }

            public void DFS(int node, long currSum)
            {
                usedNodes.Add(node);
                currSum += node;

                foreach (var connection in adjacent[node])
                {
                    if (!usedNodes.Contains(connection))
                    {
                        DFS(connection, currSum);
                    }
                    else
                    {
                        continue;
                    }
                }

                if (currSum > maxSumValue)
                {
                    maxSumValue = currSum;
                }
            }

            public void AddConnections(int parent, int child)
            {
                if (!adjacent.ContainsKey(parent))
                {
                    adjacent.Add(parent, new List<int>());
                }
                adjacent[parent].Add(child);

                if (!adjacent.ContainsKey(child))
                {
                    adjacent.Add(child, new List<int>());
                }

                adjacent[child].Add(parent);
            }
        }
    }
}
