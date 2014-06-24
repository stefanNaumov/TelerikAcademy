using System;

class CopyrigthSymbol
{
    static void Main()
    {
        int triangleSize = 9;
        char symbol = '\u00A9';
        for (int i = 0; i < triangleSize; i++)   // Main cycle for each row of the triangle.
        {
            for (int j = triangleSize - i; j > 0; j--) //First sub-cycle for the empty spaces on the left side of the symbols.
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)    //Second sub-cycle for writing the symbol(s) + the empty spaces on their rigth side.
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine(); //Then return to the main cycle to write on the next row.
        }
    }
}

