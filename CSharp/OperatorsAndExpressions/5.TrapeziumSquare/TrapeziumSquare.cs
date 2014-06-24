using System;



class TrapeziumSquare
{
    static void Main()
    {
        Console.WriteLine("Моля въведете дължина на страна А на трапеца:");
        decimal trapeziumSideA = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Моля въведете дължина на страна Б на трапеца:");
        decimal trapeziumSideB = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Моля въведене височината на трапеца");
        decimal trapeziumHeight = decimal.Parse(Console.ReadLine());
        decimal a = (trapeziumSideA + trapeziumSideB) / 2*trapeziumHeight ;
        Console.Write("Това е лицето на трапеца:");
        Console.WriteLine(a);
    }
}

