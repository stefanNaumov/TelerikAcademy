using System;

class Cards
{
    static void Main()
    {
        string[] colors = new string[4] { "Hearts", "Clubs", "Diamonds", "Spades" };
        foreach (string color in colors)
        {
            for (int Card = 1; Card < 14; Card++)
            {
                switch (Card)
                {
                    case 1:
                        Console.WriteLine("Ace {0}", color);
                        break;
                    case 2:
                        Console.WriteLine("2 {0}", color);
                        break;
                    case 3:
                        Console.WriteLine("3 {0}", color);
                        break;
                    case 4:
                        Console.WriteLine("4 {0}", color);
                        break;
                    case 5:
                        Console.WriteLine("5 {0}", color);
                        break;
                    case 6:
                        Console.WriteLine("6 {0}", color);
                        break;
                    case 7:
                        Console.WriteLine("7 {0}", color);
                        break;
                    case 8:
                        Console.WriteLine("8 {0}", color);
                        break;
                    case 9:
                        Console.WriteLine("9 {0}", color);
                        break;
                    case 10:
                        Console.WriteLine("10 {0}", color);
                        break;
                    case 11:
                        Console.WriteLine("11 {0}", color);
                        break;
                    case 12:
                        Console.WriteLine("Jack {0}", color);
                        break;
                    case 13:
                        Console.WriteLine("Queen {0}", color);
                        break;
                    case 14:
                        Console.WriteLine("King {0}", color);
                        break;
                }
            }
        }
    }
}

