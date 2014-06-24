using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:

//We are living in an yellow submarine. We don't have anything else.
//Inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9.



class CountSubstring
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        int result = SubstringCounter(text);
        if (result != -1)
        {
            Console.WriteLine("The substring \"in\" appears {0} times in the string ", result);
        }
        else
        {
            Console.WriteLine("No such substring!");
        }
    }
    static int SubstringCounter(string text)
    {
        text = text.ToLower();
        int index = text.IndexOf("in");
        int counterOfSubstrings = 0;

        while (index != -1)
        {
            counterOfSubstrings++;
            index = text.IndexOf("in", index + 1);
        }
        return counterOfSubstrings;
    }
}


