using System;
using System.Collections.Generic;
using System.Text;


//Write a program to convert binary numbers to hexadecimal numbers (directly).



class BinaryToHex
{
    static void Main()
    {
        string bin = "010011110001";
        
        
        Console.WriteLine(BinaryToHexadecimal(bin));
    }
    static string BinaryToHexadecimal(string bin)
    {
        string result = "";
        
        while(bin.Length % 4 != 0)
        {
            bin += "0";
            
        }
        for (int i = 0; i < bin.Length; i += 4)
        {
            string subStr = bin.Substring(i,4);
            result += string.Format("{0:X}",Convert.ToByte(subStr,2));
        }
        return result;
    }
}

