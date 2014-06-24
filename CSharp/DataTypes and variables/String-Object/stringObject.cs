using System;


class stringObject
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object c = a + " "+  b;
        string result = c.ToString();
        Console.WriteLine(result);
    }
}

