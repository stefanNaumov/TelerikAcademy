using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{   [Version(2,11)]
    class Program
    {
        static void Main()
        {
            Type type = typeof(Program);
            object[] attributes = type.GetCustomAttributes(false);
            
            foreach (Version attr in attributes)
            {
                Console.WriteLine("Version is: {0}.{1}",attr.major,attr.minor);
            }

        }
    }
}
