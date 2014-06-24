using System;

class ExerciseOne
{
    static void Main()
    {
        for (int count = 0; count < 10; count+=2)
        {
            Console.Write(count);
            System.Threading.Thread.Sleep(400);
            Console.Write("\n");
        }
        while (true)
        {
            ConsoleKeyInfo code = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Key name:" + code.Key);
            Console.WriteLine("Key number:" + (double)code.Key);
            Console.WriteLine("Special keys:" + code.Modifiers);
            Console.WriteLine("Entered character:" + code.KeyChar);
        }
    }
}

