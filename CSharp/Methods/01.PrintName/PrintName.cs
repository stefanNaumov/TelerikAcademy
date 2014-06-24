using System;
using System.Collections.Generic;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.


class PrintName
{
    static void Main()
    {
        PrintYourName();
    }
    static void PrintYourName()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",name);
    }

}

