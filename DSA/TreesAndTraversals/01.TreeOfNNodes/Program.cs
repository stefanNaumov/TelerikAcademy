using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfNNodes
{
    class Program
    {
        static List<Node<int>> path;
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }
            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childrenId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childrenId]);
            }

            //1. Find Root
            Node<int> root = FindRoot(nodes);
            Console.WriteLine("The tree root is: {0}", root.Value);

           // //2. Find Leafs
           // List<Node<int>> leafs = FindLeafs(nodes);
           // Console.Write("The leafs are: ");
           // for (int i = 0; i < leafs.Count; i++)
           // {
           //     if (i >= leafs.Count-1)
           //     {
           //         Console.Write(leafs[i].Value);
           //         break;
           //     }
           //     Console.Write(leafs[i].Value + ",");
           // }
           // Console.WriteLine();

           // //3.Find Middle Nodes
           // List<Node<int>> middleNodes = FindMiddleNodes(nodes, root, leafs);
           // Console.Write("The middle nodes are: ");
           // for (int i = 0; i < middleNodes.Count; i++)
           // {
           //     if (i >= middleNodes.Count - 1)
           //     {
           //         Console.Write(middleNodes[i].Value);
           //         break;
           //     }
           //     Console.Write(middleNodes[i].Value + ",");
           // }
           // Console.WriteLine();

           // //4.Find Longest Path
           //int path = FindLongestPath(root);
           //Console.WriteLine("The longest path is: {0}",path);
           //5.Find all paths with given sum of their nodes
           List<List<int>> threePaths = new List<List<int>>();
           List<int> currentPath = new List<int>();
           int sum = 9;
           int currentSum = root.Value;
           currentPath.Add(root.Value);
           FindPathsWithSum(threePaths, currentPath, root, sum, currentSum);
           Console.WriteLine("Paths with sum of their nodes {0} are: ",sum);
           for (int i = 0; i < threePaths.Count; i++)
           {
               for (int j = 0; j < threePaths[i].Count; j++)
               {
                   Console.Write(threePaths[i][j] + " ");
               }
               Console.WriteLine();
           }
           Console.Write("Subtrees with given sum: ");
           const int subTreeSum = 11;
           FindSubtreeWithGivenSum(root, subTreeSum);
        }
        private static void FindSubtreeWithGivenSum(Node<int> root, int sum)
        {
            List<int> subTree;
            bool isSubTreeWithGivenSum = false;
            foreach (var child in root.Children)
            {
                subTree = GetSubtree(child);
                if (subTree.Sum() == sum)
                {
                    Console.WriteLine(String.Join(" ",subTree));
                    isSubTreeWithGivenSum = true;
                }
                subTree.Clear();
            }
            if (!isSubTreeWithGivenSum)
            {
                Console.WriteLine("No subtree with the given sum!");
            }
        }
        private static List<int> GetSubtree(Node<int> node)
        {
            List<int> subTree = new List<int>();
            subTree.Add(node.Value);
            foreach (var child in node.Children)
            {
                subTree.Add(child.Value);
            }
            return subTree;
        }

        private static void FindPathsWithSum(List<List<int>> threePaths, List<int> currentPath, 
            Node<int> root, int sum, int currentSum)
        {
            foreach (var child in root.Children)
            {
                currentPath.Add(child.Value);
                currentSum += child.Value;
                if (currentSum == sum)
                {
                    threePaths.Add(currentPath.GetRange(0, currentPath.Count));
                }
                FindPathsWithSum(threePaths, currentPath, child, sum, currentSum);
                currentSum -= child.Value;
                currentPath.RemoveAt(currentPath.Count - 1);
            }
        }
        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }
            int longestPath = 0;
            foreach (var node in root.Children)
            {
                longestPath = Math.Max(longestPath, FindLongestPath(node));
            }
            return longestPath + 1;
        }

        private static List<Node<int>> FindMiddleNodes(Node<int>[] nodes, Node<int> root, List<Node<int>> leafs)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();
            foreach (var item in nodes)
            {
                if (item.Value != root.Value && !(leafs.Contains(item)))
                {
                    middleNodes.Add(item);
                }
            }
            return middleNodes;
        }

        private static List<Node<int>> FindLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();
            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }
            return leafs;
        }

        private static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }
            throw new ArgumentException("The tree has no root!");
        }
    }
}
