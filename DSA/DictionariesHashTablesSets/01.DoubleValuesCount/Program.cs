using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double[] array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
        Dictionary<double, int> dictionary = new Dictionary<double, int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (!(dictionary.ContainsKey(array[i])))
            {
                dictionary.Add(array[i], 1);
            }
            else
            {
                dictionary[array[i]]++;
            }
        }
        foreach (var element in dictionary)
        {
            Console.Write(element.Key + " -> " + element.Value + " times");
            Console.WriteLine();
        }
        
    }
}

