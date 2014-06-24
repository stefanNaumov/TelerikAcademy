using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphLibrary;
namespace _02.CableTVCompany
{
    class Program
    {
        static void Main()
        {
           //TODO: Implement testing of the graph
            Graph<string> graph = new Graph<string>();
            graph.AddConnection("Sofia", "Burgas", 450.0, true);
            graph.AddConnection("Sofia", "Pernik", 100.0, true);
            graph.AddConnection("Pernik", "Yambol", 30.0, true);
            graph.AddConnection("Yambol", "Burgas", 50.0, true);
            //TODO:DEBUG and find IndexOutOfRangeExc in PriorityQueue
            //graph.AddConnection("Sofia", "Pirdop", 400.0, true);
            //graph.AddConnection("Burgas", "Pirdop", 300.0, true);
            //graph.AddConnection("Pernik", "Pirdop", 1000, true);
            List<Edge<string>> minSpanTree = graph.FindMinimalSpanningTree("Sofia");
            Console.WriteLine(minSpanTree.Count);
            foreach (var item in minSpanTree)
            {
                Console.Write(item.Start.Name + " - > " + item.End.Name + " " + item.Distance);
                Console.WriteLine();
            }
        }
    }
}
