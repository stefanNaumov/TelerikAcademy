using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Node<T>:IComparable
    {
        public T Name { get; private set; }
        public double Distance { get; private set; }
        public List<Edge<T>> Connections { get; private set; }

        public Node(T name)
        {
            this.Name = name;
            this.Connections = new List<Edge<T>>();
        }

        public void AddConnection(Node<T> targetNode, double distance,bool twoWay)
        {
            if (targetNode == null)
            {
                throw new ArgumentNullException();
            }
            if (distance <= 0)
            {
                throw new ArgumentOutOfRangeException("Distance cannot be less or equal to zero!");
            }
            Connections.Add(new Edge<T>(this, targetNode, distance));

            if (twoWay)
            {
                targetNode.AddConnection(this, distance, false);
            }
        }

        public int CompareTo(object obj)
        {
            return this.CompareTo(obj as Node<T>);
        }
    }
}
