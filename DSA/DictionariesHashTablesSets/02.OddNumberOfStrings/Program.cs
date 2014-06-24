using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] array = new string[] {"C#", "SQL", "PHP", "PHP", "SQL", "SQL"  };
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (!(dict.ContainsKey(array[i])))
            {
                dict.Add(array[i], 1);
            }
            else
            {
                dict[array[i]]++;
            }
        }
        foreach (var item in dict)
        {
            if (item.Value % 2 != 0)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}

