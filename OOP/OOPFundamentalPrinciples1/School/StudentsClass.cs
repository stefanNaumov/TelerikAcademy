using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class StudentsClass
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private string classIdentifier;

        public StudentsClass(string className, Student[] students, Teacher[] teachers)
        {
            if (String.IsNullOrEmpty(className))
            {
                throw new ArgumentException("Invalid class name!");
            }
            if (students.Length < 1)
            {
                throw new ArgumentException("The array of students must have at least one member!");
            }
            if (teachers.Length < 1)
            {
                throw new ArgumentException("The array of teachers must have at least one member!");
            }
            this.classIdentifier = className;
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
        }

        public Student[] Students
        {
            get
            {
                return this.students.ToArray();
            }
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        public override string ToString()
        {
            StringBuilder classInfo = new StringBuilder();
            classInfo.Append("Class name is: " + classIdentifier);
            classInfo.AppendLine();
            classInfo.Append("Teachers for this class:");
            classInfo.AppendLine();
            for (int i = 0; i < teachers.Count; i++)
            {
                classInfo.AppendLine(i+1 + ": " + teachers[i].Name);
            }
            classInfo.AppendLine();
            classInfo.AppendLine("Students in this class:");
            for (int i = 0; i < students.Count; i++)
            {
                classInfo.AppendLine(i+1 + ": " + students[i].Name + "****" + " Number: " + students[i].Number);
            }
            classInfo.Append("====================================");
            return classInfo.ToString();
        }
    }
}
