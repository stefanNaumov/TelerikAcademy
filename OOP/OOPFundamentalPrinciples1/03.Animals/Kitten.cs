using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten:Cat,ISound
    {
        public Kitten(int age, string name, string sex)
            : base(age, name, sex)
        {
            if (sex.ToLower() != "female")
            {
                throw new ArgumentException("Kittens must be female only!");
            }
        }
        public new void ProduceSound()
        {
            Console.WriteLine("ihi ihi");
        }
    }
}
