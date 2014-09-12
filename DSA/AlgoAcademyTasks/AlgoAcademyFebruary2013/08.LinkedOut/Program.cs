using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.LinkedOut
{
    class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Connetions = new List<Person>();
        }

        public Person(string name, int value)
            :this(name)
        {
            this.Value = value;
        }

        public int Value { get; set; }

        public string Name { get; set; }

        public List<Person> Connetions { get; set; }
    }

    class Program
    {
        static Dictionary<string, Person> people = new Dictionary<string, Person>();
        static List<string> targets = new List<string>();
        static HashSet<string> used = new HashSet<string>();
        static string rootName;

        static void Main()
        {
            rootName = Console.ReadLine();
            //people.Add(rootName, new Person(rootName, 0));

            ParseInput();

            ProccessGraph();

            PrintInput();
        }

        static void PrintInput()
        {
            foreach (var personName in targets)
            {
                if (!people.ContainsKey(personName))
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(people[personName].Value);
                }
                
            }
        }

        static void ParseInput()
        {
            int numberOfConnections = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfConnections; i++)
            {
                string[] currConnection = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                string firstUserName = currConnection[0];
                string secondUserName = currConnection[1];

                if (!people.ContainsKey(firstUserName))
                {
                    people.Add(firstUserName, new Person(firstUserName));
                }

                if (!people.ContainsKey(secondUserName))
                {
                    people.Add(secondUserName, new Person(secondUserName));
                }

                people[firstUserName].Connetions.Add(people[secondUserName]);
                people[secondUserName].Connetions.Add(people[firstUserName]);
            }

            int numberOfTargets = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTargets; i++)
            {
                string targetName = Console.ReadLine();
                targets.Add(targetName);
            }
        }

        static void ProccessGraph()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue(rootName);
            used.Add(rootName);

            while (queue.Count > 0)
            {
                Person currPerson = people[queue.Dequeue()];

                foreach (Person person in currPerson.Connetions)
                {
                    if (!used.Contains(person.Name))
                    {
                        used.Add(person.Name);
                        person.Value += currPerson.Value + 1; 
                        queue.Enqueue(person.Name);
                    }
                }

            }
        }
    }
}
