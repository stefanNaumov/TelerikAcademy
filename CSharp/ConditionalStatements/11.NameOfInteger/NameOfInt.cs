using System;

class Program

{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] numLetters = new string[] { "zero","one", "two", "three", "four", "five", "six", "seven", "eigth", "nine", "ten", };

        if (number < 10)
        {
            for (int i = 0; i < numLetters.Length; i++)
            {
                if (number == i)
                {
                    Console.WriteLine(numLetters[i]);
                }
            }
        }
    }
}


