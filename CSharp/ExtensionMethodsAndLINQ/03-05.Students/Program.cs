using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main()
        {
            var students = new Student[]
            {
                new Student{FirstName = "Ivan",LastName = "Ivanov",Age = 23},
                new Student{FirstName = "Gosho",LastName = "Goshov",Age = 35},
                new Student{FirstName = "Stamat",LastName = "Stamatii",Age = 19}
            };

            //task 03
            Console.WriteLine("Students whose first name is lexicographically before their last name:");
            var firstNameBeforeLastName = SortComparingFirstAndLastName(students);
            PrintStudents(firstNameBeforeLastName);
            Console.WriteLine();

            //task 04
            Console.WriteLine("Students aged between 18 and 24:");
            var sortByAge = SortByAge(students,18,24);
            PrintStudents(sortByAge);
            Console.WriteLine();
            //task 05
            Console.WriteLine("Sorted students by their names in descending order using lambda expression: ");
            //using lambda expression
            var sortByNameWithLambda = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName);

            PrintStudents(sortByNameWithLambda);
            Console.WriteLine();
            //using LINQ
            Console.WriteLine("Sorted students by their names in descending order using LINQ: ");
            var sortByNameWithLINQ = from student in students
                                       orderby student.FirstName descending,
                                       student.LastName descending
                                       select student;
            PrintStudents(sortByNameWithLINQ);
        }

        private static IEnumerable<Student> SortByAge(Student[] students,int minAge,int maxAge)
        {
            var sortByAge = from student in students
                            where student.Age >= minAge && student.Age <= maxAge
                            select student;
            return sortByAge;
        }

        private static void PrintStudents(IEnumerable<Student> firstNameBeforeLastName)
        {
            foreach (var item in firstNameBeforeLastName)
            {
                Console.WriteLine("{0} - {1}", item.FirstName, item.LastName);
            }
        }

        private static IEnumerable<Student> SortComparingFirstAndLastName(Student[] students)
        {
            var firstNameBeforeLastName = from student in students
                                          where student.FirstName.CompareTo(student.LastName) < 0
                                          select student;
            return firstNameBeforeLastName;
        }
        
    }
}
