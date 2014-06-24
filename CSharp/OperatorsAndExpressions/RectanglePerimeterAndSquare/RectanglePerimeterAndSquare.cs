using System;


class RectanglePerimeterAndSquare
{
    static void Main()
    {
        Console.WriteLine("Моля въведете дължината А на правоъгълникът:");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Моля въведете височината Б на правоъгълникът:");
        int B = int.Parse(Console.ReadLine());
        int Sqr = A * B;
        Console.WriteLine("Лицето на правоъгълникът е:");
        Console.WriteLine(Sqr);
        int Per = 2 * (A + B);
        Console.WriteLine("Периметърът на правоъгълникът е:");
        Console.WriteLine(Per);
    }
}

