using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Palindromes
{
    static void Main()
    {
        string text = "Some sample text and a date: 04.08.2013 and some other sample text but this is not a date: 25.54.23213 abba" + 
                    "gosho pesho and lamal are friends which like to listen to ABBA and don't know what exe is";
        string palindromes = ExtractPalindromes(text);
        Console.WriteLine(palindromes);
       
    }
    //if a reversed string is equal to it's original state - it is a palindrome
    static bool IsPalindrome(string word)
    {
        char[] wordToArr = word.ToCharArray();
        Array.Reverse(wordToArr);
        
        return word == new string(wordToArr);
    }
    static string ExtractPalindromes(string text)
    {
        StringBuilder builder = new StringBuilder();
        string[] textToArray = text.Split(' ');
        for (int i = 0; i < textToArray.Length; i++)
        {
            if(IsPalindrome(textToArray[i]) == true && textToArray[i].Length > 1) //check word length to avoid extracting letters like "a"
            {
                builder.Append(textToArray[i] + "\n");
            }
        }
        return builder.ToString();
    }
}

