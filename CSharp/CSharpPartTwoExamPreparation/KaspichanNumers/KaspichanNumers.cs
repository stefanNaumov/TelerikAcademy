using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KaspichanNumers
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<string> durankulakNumber = new List<string>();
        List<string> letters = new List<string>();
        if (number == 0)
        {
            Console.WriteLine("A");
        }
        else
	    {
	        for (char i = 'A'; i <= 'Z'; i++)
            {
                letters.Add(i.ToString());
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    letters.Add(i.ToString() + j.ToString());
                }
            }
            while (number != 0)
            {
                ulong remainder = number % 256;
                string currentDigit = letters[(int)remainder];
                durankulakNumber.Add(currentDigit);
                number /= 256;
            }
            durankulakNumber.Reverse();
            for (int i = 0; i < durankulakNumber.Count; i++)
            {
                Console.Write(durankulakNumber[i]);
            }
            Console.WriteLine(); 
	    }
        
        //int a = 280;
        //string b = "";
        //while (a != 0)
        //{
        //    int res = a % 256;
        //    b += res.ToString() + " ";
        //    a /= 256;
        //}
        //Console.WriteLine(b);
        
    }
}