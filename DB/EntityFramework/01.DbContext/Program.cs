using _01.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database

namespace DbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();
        }
    }
}
