using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main()
        {
            Discipline[] discipline = new Discipline[1];
            discipline[0] = new Discipline("Physics", 3, 3);
            Student student = new Student("Pesho",23);
            Student[] studentsArr = new Student[2];
            //add students to array
            for (int i = 0; i < 2; i++)
            {
                studentsArr[i] = student;
            }
            Teacher teacher = new Teacher("Stamat",discipline);
            Teacher[] teachersArr = new Teacher[2];
            //add teachers to array
            for (int i = 0; i < 2; i++)
            {
                teachersArr[i] = teacher;
            }
            StudentsClass currentClass = new StudentsClass("Tikvenici",studentsArr,teachersArr);
            StudentsClass[] classes = new StudentsClass[2];
            //add classes to array
            for (int i = 0; i < 2; i++)
            {
                classes[i] = currentClass;
            }
            //show classes info
            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine(classes[i]);
            }

        }
    }
}
