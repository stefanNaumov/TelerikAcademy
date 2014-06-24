using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.



class ConvertNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        //to decimal
        Console.WriteLine("{0} as decimal: {1,15}",number,number);
        //as hexadecimal
        Console.WriteLine("{0} as hexadecimal: {1,15:X}",number,number);
        //as percentage
        Console.WriteLine("{0} as percentage: {1,15:P}",number,(double)number/100);
        //as scientific notation
        Console.WriteLine("{0} as scientific notation: {1,15:E}",number,number);
    }
    
}

