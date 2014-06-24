using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog: Animal,ISound
    {
        private int age;
        private string name;
        private string sex;
        private string sound;
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }
        public void ProduceSound()
        {
            Console.WriteLine("Bau!");
        }
    }
}
