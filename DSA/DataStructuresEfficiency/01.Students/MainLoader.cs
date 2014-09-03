using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Wintellect.PowerCollections;

//A text file students.txt holds information about students and their courses in the following format:
//Kiril  | Ivanov   | C#
//Stefka | Nikolova | SQL
//Stela  | Mineva   | Java
//Milena | Petrova  | C#
//Ivan   | Grigorov | C#
//Ivan   | Kolev    | SQL
//Using SortedDictionary<K,T> print the courses in alphabetical order
//and for each of them prints the students ordered by family and then by name:

namespace Students
{
    class MainLoader
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Students.txt");
            SortedDictionary<string, List<Student>> courses = new SortedDictionary<string, List<Student>>();

            using (reader)
            {
                string currLineStr = reader.ReadLine();

                while (currLineStr != null)
                {
                    string[] currLineArr = currLineStr.Split(new char[] { ' ', '|' },StringSplitOptions.RemoveEmptyEntries);
                    string firstName = currLineArr[0];
                    string lastName = currLineArr[1];
                    string course = currLineArr[2];

                    if (!courses.ContainsKey(course))
                    {
                        courses.Add(course, new List<Student>());
                    }
                    Student student = new Student(firstName, lastName);
                    
                    courses[course].Add(student);
                    currLineStr = reader.ReadLine();
                }
            }

            foreach (var item in courses)
            {
                Console.Write(item.Key + ": ");
                var sortedStudents = item.Value.OrderBy(s => s.LastName).ThenBy(s => s.FirstName);

                foreach (var student in sortedStudents)
                {
                    Console.Write(student.FirstName + " " + student.LastName + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
