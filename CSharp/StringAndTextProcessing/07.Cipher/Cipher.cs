using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.



class Cipher
{
    static void Main()
    {
        Console.Write("Enter text to be encoded:");
        string word = Console.ReadLine();
        Console.Write("Enter your encryption key (cipher): ");
        string cipher = Console.ReadLine();
        string encoded = CipherEncoding(word, cipher);
        string decoded = CipherDecoding(encoded, cipher);
        Console.WriteLine("Encrypted: {0}",encoded);
        Console.WriteLine("Decrypted: {0}",decoded);
        
    }
    static string CipherEncoding(string word,string cipher)
    {
        StringBuilder builder = new StringBuilder();
        int cipherPosition = 0;

        for (int i = 0; i < word.Length;cipherPosition++, i++)
        {
            if (cipherPosition >= cipher.Length - 1)
            {
                cipherPosition = 0;
            }

            builder.Append((char)(word[i] ^ cipher[cipherPosition]));
            
            
        }
        return builder.ToString();
    }
    static string CipherDecoding(string encodedWord, string cipher)
    {
        StringBuilder builder = new StringBuilder();
        int cipherPosition = 0;

        for (int i = 0; i < encodedWord.Length;cipherPosition++, i++)
        {
            if (cipherPosition >= cipher.Length - 1)
            {
                cipherPosition = 0;
            }
            builder.Append((char)(encodedWord[i] ^ cipher[cipherPosition]));
        }
        return builder.ToString();
    }
}

