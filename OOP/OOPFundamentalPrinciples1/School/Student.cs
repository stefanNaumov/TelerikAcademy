using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student: Human
    {
        private int studentNumber;
        private string comment;
        public Student(string name, int studentNumber)
            : base(name) //use constructor in base class Human
        {
            this.studentNumber = studentNumber;
        }

        public int Number
        {
            get { return this.studentNumber; }
        }
        public string Comment
        {
            get { return this.comment; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid comment!");
                }
                this.comment = value;
            }
        }
    }
}
