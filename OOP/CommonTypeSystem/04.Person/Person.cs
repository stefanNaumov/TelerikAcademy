using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//04 - Create a class Person with two fields – name and age. 
//Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so. 
//Write a program to test this functionality.

namespace Person
{
    public class Person
    {
        private string name;
        private Nullable<uint> age; // a variable like int? uses Nullable<int>
        public Person(string name)
            : this(name,null)
        {

        }
        public Person(string name, Nullable<uint> age)
        {
            this.name = name;
            this.age = age;
        }
        //override the ToString() method
        public override string ToString()
        {
            StringBuilder personStr = new StringBuilder();
            personStr.AppendLine("Name: " + this.name);
            personStr.AppendLine(this.age == null ? "Age is not specified!" : "Age: " + this.age); 
            //if (this.age == null)
            //{
            //    personStr.AppendLine("Age is not specified!");
            //}
            //else
            //{
            //    personStr.AppendLine("Age: " + this.age);
            //}
            return personStr.ToString();
        }
    }
}
