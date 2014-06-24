using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat: Cat,ISound
    {
        public Tomcat(int age, string name, string sex)
            : base(age, name, sex)
        {
            if (sex.ToLower() != "male")
            {
                throw new ArgumentException("Tomcats must be males only!");
            }
        }
        public new string ProduceSound()
        {
            return "mrrr";
        }
    }
}
