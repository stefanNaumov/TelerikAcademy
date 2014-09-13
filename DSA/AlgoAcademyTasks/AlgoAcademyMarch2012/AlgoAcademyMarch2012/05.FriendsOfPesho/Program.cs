using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FriendsOfPesho
{
    class Program
    {
        static Dictionary<int, Node> nodes = new Dictionary<int, Node>();

        static Dictionary<Node, List<Edge>> graphConnecitons = new Dictionary<Node, List<Edge>>();

        static void Main()
        {
            string[] nodesAndConnections = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            int allNodes = int.Parse(nodesAndConnections[0]);
            int hospitalsCount = int.Parse(nodesAndConnections[2]);
            int numberOfConnections = int.Parse(nodesAndConnections[1]);
            int numberOfHouses = int.Parse(nodesAndConnections[0]) - hospitalsCount;

            int[] hospitals = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            ParseConnections(numberOfConnections, hospitals);

            

            for (int i = 0; i < hospitals.Length; i++)
            {
                nodes[hospitals[i]].IsHospital = true;
            }

            long maxSum = long.MaxValue;

            for (int i = 0; i < hospitals.Length; i++)
            {
                long tempSum = 0;
                Djikstra(nodes[hospitals[i]]);

                foreach (var node in nodes)
                {
                    if (!node.Value.IsHospital)
                    {
                        tempSum += node.Value.DjikstraDistance;
                    }
                    
                }

                if (tempSum < maxSum)
                {
                    maxSum = tempSum;
                }
            }

            Console.WriteLine(maxSum);
        }

        public static void ParseConnections(int numberOfConnections, int[] hospitals)
        {
            for (int i = 0; i < numberOfConnections; i++)
            {
                int[] currConnection = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                int firstValue = currConnection[0];
                int secondValue = currConnection[1];
                int weight = currConnection[2];

                if (!nodes.ContainsKey(firstValue))
                {
                    nodes.Add(firstValue, new Node(firstValue));
                }

                if (!nodes.ContainsKey(secondValue))
                {
                    nodes.Add(secondValue, new Node(secondValue));
                }

                Node firstNode = nodes[firstValue];
                Node secondNode = nodes[secondValue];

                if (!graphConnecitons.ContainsKey(firstNode))
                {
                    graphConnecitons.Add(firstNode, new List<Edge>());
                }

                if (!graphConnecitons.ContainsKey(secondNode))
                {
                    graphConnecitons.Add(secondNode, new List<Edge>());
                }

                graphConnecitons[firstNode].Add(new Edge(secondNode, weight));
                graphConnecitons[secondNode].Add(new Edge(firstNode, weight));
            }
        }

        public static void Djikstra(Node root)
        {
            PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>();

            foreach (var node in graphConnecitons)
            {
                node.Key.DjikstraDistance = long.MaxValue;
            }

            root.DjikstraDistance = 0;

            priorityQueue.Enqueue(root);

            while (priorityQueue.Count > 0)
            {
                Node currNode = priorityQueue.Dequeue();

                if (currNode.DjikstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var edge in graphConnecitons[currNode])
                {
                    var distance = edge.Weight + currNode.DjikstraDistance;

                    if (distance < edge.End.DjikstraDistance)
                    {
                        edge.End.DjikstraDistance = distance;
                        priorityQueue.Enqueue(edge.End);
                    }
                }
            }
        }

        public class Edge
        {
            public int Weight { get; set; }

            public Node End { get; set; }

            public Edge(Node endNode, int distance)
            {
                this.End = endNode;
                this.Weight = distance;
            }
        }

        public class Node: IComparable
        {
            public int Value { get; set; }

            public long DjikstraDistance { get; set; }

            public bool IsHospital { get; set; }

            public Node(int value)
            {
                this.Value = value;
            }

            public int CompareTo(object obj)
            {
                return this.DjikstraDistance.CompareTo((obj as Node).DjikstraDistance);
            }
        }

        public class PriorityQueue<T> where T : IComparable
        {
            private T[] heap;
            private int index;

            public PriorityQueue()
            {
                this.heap = new T[16];
                this.index = 1;
            }

            public int Count
            {
                get
                {
                    return this.index - 1;
                }
            }

            public void Enqueue(T element)
            {
                if (this.index >= this.heap.Length)
                {
                    this.IncreaseArray();
                }

                this.heap[this.index] = element;

                int childIndex = this.index;
                int parentIndex = childIndex / 2;
                this.index++;

                while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
                {
                    T swapValue = this.heap[parentIndex];
                    this.heap[parentIndex] = this.heap[childIndex];
                    this.heap[childIndex] = swapValue;

                    childIndex = parentIndex;
                    parentIndex = childIndex / 2;
                }
            }

            public T Dequeue()
            {
                T result = this.heap[1];

                this.heap[1] = this.heap[this.Count];
                this.index--;

                int rootIndex = 1;

                while (true)
                {
                    int leftChildIndex = rootIndex * 2;
                    int rightChildIndex = (rootIndex * 2) + 1;

                    if (leftChildIndex > this.index)
                    {
                        break;
                    }

                    int minChild;
                    if (rightChildIndex > this.index)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                        {
                            minChild = leftChildIndex;
                        }
                        else
                        {
                            minChild = rightChildIndex;
                        }
                    }

                    if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                    {
                        T swapValue = this.heap[rootIndex];
                        this.heap[rootIndex] = this.heap[minChild];
                        this.heap[minChild] = swapValue;

                        rootIndex = minChild;
                    }
                    else
                    {
                        break;
                    }
                }

                return result;
            }

            public T Peek()
            {
                return this.heap[1];
            }

            private void IncreaseArray()
            {
                var copiedHeap = new T[this.heap.Length * 2];

                for (int i = 0; i < this.heap.Length; i++)
                {
                    copiedHeap[i] = this.heap[i];
                }

                this.heap = copiedHeap;
            }
        }
    }

}
