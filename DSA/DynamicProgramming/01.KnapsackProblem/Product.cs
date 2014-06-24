using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KnapsackProblem
{
    class Product
    {
        private string name;
        private int weight;
        private int cost;
        public Product(string name, int weight, int cost)
        {
            this.name = name;
            this.weight = weight;
            this.cost = cost;
        }
        public string Name 
        {
            get { return this.name; }
        }
        public int Weight
        {
            get { return this.weight; }
        }
        public int Cost
        {
            get { return this.cost; }
        }
    }
}
