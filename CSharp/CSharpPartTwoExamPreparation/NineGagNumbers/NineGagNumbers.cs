using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

class NineGagNumbers
{
    static void Main()
    {
        string gagNum = Console.ReadLine();
        BigInteger result = NineGagValue(gagNum);
        Console.WriteLine(result);

    }
    static BigInteger RaiseNumberToPower(int number)
    {
        BigInteger result = 1;
        for (int i = 0; i < number; i++)
        {
            result *= 9;
        }
        return result;
        
    }
    static BigInteger NineGagValue(string gagNumber)
    {
        BigInteger result = 0;

        string[] gagNumbers = new string[] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        StringBuilder builder = new StringBuilder();
        
        List<string> numbers = new List<string>();

        for (int i = 0; i < gagNumber.Length; i++)
        {
            builder.Append(gagNumber[i]);
            
            for (int j = 0; j < gagNumbers.Length; j++)
            {
                if (builder.ToString() == gagNumbers[j])
                {
                    numbers.Add(gagNumbers[j]);
                    builder.Clear();
                    
                }
            }
        }
        numbers.Reverse();
        
        string curr = null;
        for (int i = 0; i < numbers.Count; i++)
        {
            curr = numbers[i];
            for (int j = 0; j < gagNumbers.Length; j++)
            {
                if (curr == gagNumbers[j])
                {
                    result += (j * RaiseNumberToPower(i));
                }
            }
        }
        return (ulong)result;
    }
    
}
