using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private string sex;
        private string sound;
        protected Animal(int age,string name, string sex)
        {
            if (age < 0)
            {
                throw new ArgumentException("Animal age cannot be a negative value!");
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Invalid name!");
            }
            if (sex.ToLower() != "male" && sex.ToLower() != "female")
            {
                throw new ArgumentException("Sex must be male or female!");
            }
            this.age = age;
            this.name = name;
            this.sex = sex;
        }
        public int Age
        {
            get { return this.age; }
        }
    }
}
