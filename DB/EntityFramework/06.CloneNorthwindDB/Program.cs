using System;
namespace _06.CloneNorthwindDB
{
    class Program
    {
        static void Main()
        {
            //change db name in the initial catalog field in app.config file
            NorthwindEntities northwindClone = new NorthwindEntities();
            northwindClone.Database.CreateIfNotExists();
        }
    }
}
