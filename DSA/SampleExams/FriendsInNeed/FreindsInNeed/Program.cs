using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreindsInNeed
{
    class Program
    {


        static void Main()
        {
            string[] pointsInput = Console.ReadLine().Split(' ');

            int hospitalsCount = int.Parse(pointsInput[2]);

            int homesCount = int.Parse(pointsInput[0]) - hospitalsCount;

            int streetsCount = int.Parse(pointsInput[1]);

            string[] hospitals = Console.ReadLine().Split(' ');

            Dictionary<Node, List<Connection>> graphObjects = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

            for (int i = 0; i < streetsCount; i++)
            {
                string[] currLine = Console.ReadLine().Split(' ');

                int firstNode = int.Parse(currLine[0]);
                int secondNode = int.Parse(currLine[1]);
                int distance = int.Parse(currLine[2]);

                if (!allNodes.ContainsKey(firstNode))
                {
                    allNodes.Add(firstNode, new Node(firstNode));
                }
                if (!allNodes.ContainsKey(secondNode))
                {
                    allNodes.Add(secondNode, new Node(secondNode));
                }

                Node firstNodeObj = allNodes[firstNode];
                Node secondNodeObj = allNodes[secondNode];

                if (!graphObjects.ContainsKey(firstNodeObj))
                {
                    graphObjects.Add(firstNodeObj, new List<Connection>());
                }
                if (!graphObjects.ContainsKey(secondNodeObj))
                {
                    graphObjects.Add(secondNodeObj, new List<Connection>());
                }

                graphObjects[secondNodeObj].Add(new Connection(firstNodeObj, distance));
                graphObjects[firstNodeObj].Add(new Connection(secondNodeObj, distance));
            }


            for (int i = 0; i < hospitals.Length; i++)
            {
                int currHospital = int.Parse(hospitals[i]);
                allNodes[currHospital].isHospital = true;
            }

            long result = long.MaxValue;

            for (int i = 0; i < hospitals.Length; i++)
            {
                int currentHospital = int.Parse(hospitals[i]);
                long tempSum = 0;

                DijsktraTraverse(graphObjects, allNodes[currentHospital]);

                foreach (var item in allNodes)
                {
                    if (!item.Value.isHospital)
                    {
                        tempSum += item.Value.DijkstraDistance;
                    }
                }

                if (tempSum < result)
                {
                    result = tempSum;
                }
            }

            Console.WriteLine(result);
        }

        static void DijsktraTraverse(Dictionary<Node, List<Connection>> graph, Node startNode)
        {
            PriorityQueue<Node> nodes = new PriorityQueue<Node>();
            foreach (var pair in graph)
            {
                pair.Key.DijkstraDistance = long.MaxValue;
            }

            startNode.DijkstraDistance = 0;
            nodes.Enqueue(startNode);

            while (!nodes.IsEmpty)
            {
                Node currentNode = nodes.Dequeue();

                foreach (var connection in graph[currentNode])
                {
                    long tempDistance = currentNode.DijkstraDistance + connection.Distance;

                    if (tempDistance < connection.ConnectionTo.DijkstraDistance)
                    {
                        connection.ConnectionTo.DijkstraDistance = tempDistance;
                        nodes.Enqueue(connection.ConnectionTo);
                    }
                }
            }
        }

        class Node : IComparable<Node>
        {
            public Node(int value)
            {
                this.Value = value;
                this.isHospital = false;
            }
            public long DijkstraDistance { get; set; }

            public int Value { get; private set; }

            public bool isHospital { get; set; }

            public int CompareTo(Node other)
            {
                return this.DijkstraDistance.CompareTo(other.DijkstraDistance);
            }
        }

        class Connection
        {
            public Connection(Node connectionTo, int distance)
            {
                this.ConnectionTo = connectionTo;
                this.Distance = distance;
            }

            public int Distance { get; private set; }

            public Node ConnectionTo { get; private set; }
        }

        public class PriorityQueue<T> where T : IComparable<T>
        {
            private readonly LinkedList<T> _items;

            public PriorityQueue()
            {
                _items = new LinkedList<T>();
            }

            #region IPriorityQueue<T> Members

            public void Enqueue(T item)
            {
                if (IsEmpty)
                {
                    _items.AddFirst(item);
                    return;
                }

                LinkedListNode<T> existingItem = _items.First;

                while (existingItem != null && existingItem.Value.CompareTo(item) < 0)
                {
                    existingItem = existingItem.Next;
                }

                if (existingItem == null)
                    _items.AddLast(item);
                else
                {
                    _items.AddBefore(existingItem, item);
                }
            }

            public T Dequeue()
            {
                T value = _items.First.Value;
                _items.RemoveFirst();

                return value;
            }

            public T Peek()
            {
                return _items.First.Value;
            }

            public bool IsEmpty
            {
                get { return _items.Count == 0; }
            }

            public IEnumerator<T> GetEnumerator()
            {
                return _items.GetEnumerator();
            }

            //IEnumerator IEnumerable.GetEnumerator()
            //{
            //    return GetEnumerator();
            //}

            #endregion
        }
    }
}
