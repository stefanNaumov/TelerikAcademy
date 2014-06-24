using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Student : Human
    {
        private int grade;
        public Student(string firstName, string lastName,int grade):base(firstName,lastName)
        {
            if (grade < 2 || grade > 6)
            {
                throw new ArgumentOutOfRangeException("Grade value must be between 2 and 6 inclusive!");
            }
            this.grade = grade;
        }
        public int Grade
        {
            get { return this.grade; }
        }
    }
}
