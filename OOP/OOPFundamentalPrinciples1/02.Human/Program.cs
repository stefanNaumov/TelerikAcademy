using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main()
        {
            var sortByGrade = StudentList().OrderBy(x => x.Grade);
            Console.WriteLine("Students ordered in ascending order by their grades:");
            Console.WriteLine("**********************************");
            foreach (var student in sortByGrade)
            {
                Console.WriteLine(student.FirstName + " - " + student.LastName);
            }
            Console.WriteLine("**********************************");
            //Console.WriteLine();
            var sortByPayment = from worker in workersList()
                                orderby worker.MoneyPerHour() descending
                                select worker;
            Console.WriteLine("Workers order by their payment per hour in descending order:");
            Console.WriteLine("**********************************");
            foreach (var worker in sortByPayment)
            {
                Console.WriteLine(worker.FirstName + " - " + worker.LastName + "|" +
                    " payment per hour:" + worker.MoneyPerHour());
            }
            Console.WriteLine("**********************************");
            var mergeAndSort = MergeTwoLists(StudentList(),workersList()).OrderBy(f => f.FirstName).ThenBy(l => l.LastName);
            //Console.WriteLine();
            Console.WriteLine("The tow lists merged and sorted by first and last name:");
            foreach (var human in mergeAndSort)
            {
                Console.WriteLine(human.FirstName + " - " + human.LastName);
            }
            Console.WriteLine("====================================================");
        }
        static List<Student> StudentList()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan","Ivanov",3),
                new Student("Drago","Dragiev",4),
                new Student("Momcho","Momchev",6),
                new Student("Ibro","Lolov",2),
                new Student("Stamat","Stamatov",3),
                new Student("Gosho","Grigorov",3),
                new Student("Taran","Taranov",3),
                new Student("Vasil","Vasilev",4),
                new Student("Patriot","Velev",5),
                new Student("Bai","Iliikata",2),
            };
            return students;
        }
        static List<Worker> workersList()
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan","Ivanov",150,8),
                new Worker("Drago","Dragiev",180,9),
                new Worker("Momcho","Momchev",300,10),
                new Worker("Ibro","Lolov",1000,6),
                new Worker("Stamat","Stamatov",200,10),
                new Worker("Gosho","Grigorov",100,13),
                new Worker("Taran","Taranov",500,12),
                new Worker("Vasil","Vasilev",50,4),
                new Worker("Patriot","Velev",100,10),
                new Worker("Bai","Bocho",10000,0),
            };
            return workers;
        }
        static List<Human> MergeTwoLists(List<Student> students, List<Worker> workers)
        {
            List<Human> merged = new List<Human>();
            for (int i = 0; i < students.Count; i++)
            {
                merged.Add(students[i]);
            }
            for (int i = 0; i < workers.Count; i++)
            {
                merged.Add(workers[i]);
            }
            return merged;
        }
    }
}