using System;

class FighterAttack
{
    static void Main()
    {
        Console.WriteLine("Enter pX1:");
        int pX1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter pY1:");
        int pY1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter pX2:");
        int pX2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter pY2:");
        int pY2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fX:");
        int fX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fY:");
        int fY = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter D:");
        int d = int.Parse(Console.ReadLine());
        int minPY = Math.Min(pY1, pY2);
        int maxPY = Math.Max(pY1, pY2);
        int minPX = Math.Min(pX1, pX2);
        int maxPX = Math.Max(pX1, pX2);
        int damage = 0;
        if ( (pX1 == pX2 || pY1 == pY2))
        {
            Console.WriteLine("Error!");
        }
        if(fX+d >= minPX && fX+d <= maxPX && fY >= minPY && fY <= maxPY)
        {
            damage += 100;
        }
        if ((fX+d)+1 >= minPX && (fX+d)+1 <= maxPX && fY >= minPY && fY <= maxPY)
        {
            damage += 75;
        }
        if (fX+d >= minPX && fX+d <= maxPX && fY+1 >= minPY && fY+1 <= maxPY)
        {
            damage += 50;
        }
        if (fX+d >= minPX && fX+d <= maxPX && fY - 1 >= minPY && fY - 1 <= maxPY)
        {
            damage += 50;
        }
        Console.WriteLine(damage+ "%");
    }
}

