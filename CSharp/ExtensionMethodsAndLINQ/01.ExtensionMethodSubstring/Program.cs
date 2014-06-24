using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSubstring
{
    class Program
    {
        static void Main()
        {
            StringBuilder b = new StringBuilder();
            b.Append("kupih si nov hladilnik!");
            StringBuilder subBuilder = new StringBuilder();
            subBuilder = b.Substring(0, 11);
            Console.WriteLine(subBuilder.ToString());
        }
    }
}
