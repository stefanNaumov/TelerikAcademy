using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Human
    {
        private string name;
        public Human(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Not a valid name!");
            }
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            
        }
    }
}
