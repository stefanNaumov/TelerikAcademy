using System;


namespace A_nacci
{
    class A_nacci
    {

        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            int firstChIndex = first - 64;
            char second = char.Parse(Console.ReadLine());
            int secondChIndex = second - 64;
            int indexsum = firstChIndex + secondChIndex;
            while (indexsum > 26)
            {
                indexsum = indexsum % 26;
            }

           
            

            int numberOfLines = int.Parse(Console.ReadLine());
            if (numberOfLines == 1)
            {
                Console.WriteLine(first);
            }
            else if (numberOfLines == 2)
            {
                Console.WriteLine(first);
                Console.Write(second);
                Console.WriteLine((char)(indexsum+64));
            }
            else
            {
                Console.WriteLine(first);
                Console.Write(second);
                Console.WriteLine((char)(indexsum + 64));
                firstChIndex = secondChIndex;
                secondChIndex = indexsum;
                for (int i = 1; i <= numberOfLines-2; i++)
                {
                    
                    for (int j = 0; j < 2; j++)
                    {
                        
                        indexsum = firstChIndex + secondChIndex;
                        while (indexsum > 26)
                        {
                            indexsum = indexsum % 26;
                        }
                        Console.Write((char)(indexsum+64));
                        firstChIndex = secondChIndex;
                        secondChIndex = indexsum;
                        if (j == 0)
                        {
                            Console.Write(new string(' ',i));
                        }
                    }
                    Console.WriteLine();

                }
            }
        }
        
    }
}
