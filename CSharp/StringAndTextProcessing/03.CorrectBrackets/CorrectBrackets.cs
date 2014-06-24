using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();
        bool checkBrackets = IfBracketsAreCorrect(expression);
        if (checkBrackets == true)
        {
            Console.WriteLine("Brackets are correct!");
        }
        else
        {
            Console.WriteLine("Brackets are incorrect!");
        }
    }
    static bool IfBracketsAreCorrect(string expression)
    {
        int openBrackets = 0;
        int closeBrackets = 0;
        bool areBracketsCorrect = false;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openBrackets++;
            }
            if (expression[i] == ')')
            {
                closeBrackets++;
            }
        }
        if (openBrackets == closeBrackets)
        {
            areBracketsCorrect = true;
        }
        return areBracketsCorrect;
    }
}

