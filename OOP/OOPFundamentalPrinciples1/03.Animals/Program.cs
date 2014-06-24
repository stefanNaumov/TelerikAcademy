using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            Dog[] dogs = new Dog[2];
            dogs[0] = new Dog(3, "Sharo", "male");
            dogs[1] = new Dog(8, "Jack", "male");
            double averageDogAge = dogs.Average(d => d.Age);
            Console.WriteLine("Average age of dogs: {0}",averageDogAge);
            Console.WriteLine("=====================================");

            Cat[] cats = new Cat[2];
            cats[0] = new Cat(5, "Tosho", "male");
            cats[1] = new Cat(9, "Dara", "female");
            double averageCatAge = dogs.Average(c => c.Age);
            Console.WriteLine("Average age of cats: {0}",averageCatAge);
            Console.WriteLine("=====================================");

            Frog[] frogs = new Frog[2];
            frogs[0] = new Frog(2, "Jabara", "female");
            frogs[1] = new Frog(11, "Gosho", "male");
            double averageFrogAge = frogs.Average(f => f.Age);
            Console.WriteLine("Average frog age: {0}",averageFrogAge);
            Console.WriteLine("=====================================");

            Kitten[] kittens = new Kitten[2];
            kittens[0] = new Kitten(1, "Penka", "female");
            kittens[1] = new Kitten(2, "Pissy", "female");
            var averageKittenAge = kittens.Average(k => k.Age);
            Console.WriteLine("Average kitten age: {0}",averageKittenAge);
            Console.WriteLine("=====================================");
            
            Tomcat[] tomcats = new Tomcat[2];
            tomcats[0] = new Tomcat(1, "Petko", "male");
            tomcats[1] = new Tomcat(10, "Baven", "male");
            var averageTomcatAge = tomcats.Average(t => t.Age);
            Console.WriteLine("Average tomcat age: {0}",averageTomcatAge);
            Console.WriteLine("=====================================");

            //ISound sounds = new Kitten(1, "Pena", "female");
            //sounds.ProduceSound();
            //sounds = new Frog(23, "A", "male");
            //sounds.ProduceSound();
        }
    }
}
