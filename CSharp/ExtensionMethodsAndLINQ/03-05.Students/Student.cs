using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        //fields
        private int age;
        private string firstName;
        private string lastName;

        //properties
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.lastName = value;
            }
        }
    }
}
