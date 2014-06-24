using System;
using System.Collections.Generic;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.




class CoupleOfMathMethods
{
    static void Main()
    {
        int[] numbersArray = new int[] { 4, 2, 6, 123, 543, 76, 3, 32, 234 }; //can cut or add more values because
                                                                             //methods are written with params  
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write(numbersArray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Minimum element: {0} ",MinElement(numbersArray));
        Console.WriteLine("Maximum element: {0} ",Maximum(numbersArray));
        Console.WriteLine("Average: {0} ",Average(numbersArray));
        Console.WriteLine("Sum: {0} ",Sum(numbersArray));
        Console.WriteLine("Product: {0} ",Product(numbersArray));
    }                       
            
    static int MinElement(params int[] numbers)
    {
        int result = 0;
        Array.Sort(numbers);
        result = numbers[0];
        return result;
    }
    static int Maximum(params int[] numbers)
    {
        int result = 0;
        Array.Sort(numbers);
        result = numbers[numbers.Length - 1];
        return result;
    }
    static int Average(params int[] numbers)
    {
        int result = 0;
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        result = sum / numbers.Length;
        return result;
    }
    static int Sum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int Product(params int[] numbers)
    {
        int result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
}

