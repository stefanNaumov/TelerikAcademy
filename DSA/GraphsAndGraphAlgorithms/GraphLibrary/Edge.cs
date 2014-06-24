using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Edge<T>:IComparable
    {
        public Node<T> Start { get; private set; }
        public Node<T> End { get; private set; }
        public double Distance { get; private set; }

        public Edge(Node<T> start, Node<T> end, double distance)
        {
            this.Start = start;
            this.End = end;
            this.Distance = distance;
        }

        public int CompareTo(object obj)
        {
            return this.Distance.CompareTo((obj as Edge<T>).Distance);
        }
    }
}
