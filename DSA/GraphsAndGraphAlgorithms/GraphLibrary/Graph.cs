using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    
    public class Graph<T>
    {
        public Dictionary<T, Node<T>> Nodes { get; private set; }
        private List<Node<T>> visited;

        public Graph()
        {
            this.Nodes = new Dictionary<T, Node<T>>();
            this.visited = new List<Node<T>>();
        }
        
        public void AddNode(T nodeName)
        {
            if (nodeName == null)
            {
                throw new ArgumentNullException();
            }
            if (Nodes.ContainsKey(nodeName))
            {
                throw new ArgumentException("Cannot add same node more than once!");
            }
            var node = new Node<T>(nodeName);
            Nodes.Add(nodeName, node);
        }

        public void AddConnection(T startNode, T endNode, double distance, bool twoWay)
        {
            //TODO: Implement adding non-existing startNode or non-existing endNode
            if (!(Nodes.ContainsKey(startNode)))
            {
                var node = new Node<T>(startNode);
                Nodes.Add(startNode,node);
            }
            if (!(Nodes.ContainsKey(endNode)))
            {
                var node = new Node<T>(endNode);
                Nodes.Add(endNode, node);
            }
            Nodes[startNode].AddConnection(Nodes[endNode], distance, twoWay);
        }

        public List<Edge<T>> FindMinimalSpanningTree(T pathStart)
        {

            var startNode = Nodes[pathStart];
            PriorityQueue<Edge<T>> queue = new PriorityQueue<Edge<T>>();
            List<Edge<T>> minSpanTree = new List<Edge<T>>();

            foreach (var conneciton in startNode.Connections)
            {
                queue.Enqueue(conneciton);
            }

            visited.Add(startNode);

            while (queue.Count > 0)
            {
                Edge<T> edge = queue.Dequeue();

                if (!(visited.Contains(edge.End)))
                {
                    var node = edge.End;
                    visited.Add(node);
                    minSpanTree.Add(edge);

                    foreach (var connection in node.Connections)
                    {
                        if (!(minSpanTree.Contains(connection)))
                        {
                            if (!(visited.Contains(connection.End)))
                            {
                                queue.Enqueue(connection);
                            }
                        }
                    }
                }
            }
            return minSpanTree;
        }
    }
}
