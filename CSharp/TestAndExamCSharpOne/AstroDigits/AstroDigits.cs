using System;

class AstroDigits
{
    static void Main()
    {
        int digitSum = 0;
        while (true)
        {
                int ch = Console.Read();
                if (ch == -1 || ch == '\r')
                {
                    break;
                }
                if (ch >= '0' && ch <= '9')
                {
                    char digit = (char)ch;
                    int final = int.Parse(digit.ToString());
                    digitSum += final;
                }
        }
        int finalSum = 0;
        int success = 0;
        do
        {
            int lastInteger = digitSum % 10;
            finalSum += lastInteger;
            digitSum = digitSum / 10;
            success = finalSum + digitSum;
        }
        while (success > 9);
        Console.WriteLine(success);
    }
}

