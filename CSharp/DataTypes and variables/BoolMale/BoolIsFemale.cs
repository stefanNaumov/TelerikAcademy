using System;


class BoolIsFemale
{
    static void Main()
    {
        Console.WriteLine("Enter your gender:");
        string gender = Console.ReadLine();
        gender = gender.ToLower(); //Lower all the letters in the word in case someone writes an input "Female" for example.
        bool isFemale = (gender == "female");
        Console.WriteLine("Are you a female? " + isFemale);
    }
    
}
