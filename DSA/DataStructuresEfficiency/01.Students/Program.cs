using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Wintellect.PowerCollections;

namespace _01.Students
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Students.txt");
            SortedDictionary<string, List<string>> courses = new SortedDictionary<string, List<string>>();

            using (reader)
            {
                string currLineStr = reader.ReadLine();

                while (currLineStr != null)
                {
                    string[] currLineArr = currLineStr.Split(new char[] { ' ', '|' },StringSplitOptions.RemoveEmptyEntries);
                    string name = currLineArr[0] + ' ' + currLineArr[1];
                    string course = currLineArr[2];

                    if (!courses.ContainsKey(course))
                    {
                        courses.Add(course, new List<string>());
                    }

                    courses[course].Add(name);
                    currLineStr = reader.ReadLine();
                }
            }
        }
    }
}
