using System;
using System.Collections.Generic;
using System.Threading;

class ExerciseTwo
{
    static void Main()
    {
        string str = Console.ReadLine();
        int value;
        bool Parsing = Int32.TryParse(str, out value);
        Console.WriteLine(Parsing ? "The number is " + value + "." : "Invalid number" + ".");
    }
}

