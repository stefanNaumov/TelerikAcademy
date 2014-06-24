using System;
using System.Collections.Generic;


//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).


class GenericMethod
{
    static void Main()
    {
        decimal[] arr = new decimal[] { 4, 23, 6, 75, 1, 22, 55 }; //could add or cut values - params in methods
        Console.WriteLine("Minimum: {0:0.00}",Minimum(arr));
        Console.WriteLine("Maximum: {0:0.00}", Maximum(arr));
        Console.WriteLine("Average: {0:0.00}", Average(arr));
        Console.WriteLine("Sum: {0:0.00}", Sum(arr));
        Console.WriteLine("Product: {0:0.00}", Product(arr));
    }

    static T Minimum<T>(params T[] numbers)
    {
        Array.Sort(numbers);
        T result = numbers[0];
        return result;
    }

    static T Maximum<T>(params T[] numbers)
    {
        Array.Sort(numbers);
        T result = numbers[numbers.Length-1];
        return result;
    }

    static T Average<T>(params T[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToDecimal(numbers[i]);
        }
        sum = sum / numbers.Length;
        T value;
        value = (T) Convert.ChangeType(sum, typeof(T));
        return value;
    }
    
    static T Sum<T>(params T[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToDecimal(numbers[i]);
        }
        return (T) Convert.ChangeType(sum, typeof(T));
    }

    static T Product<T>(params T[] numbers)
    {
        decimal sum = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum *= Convert.ToDecimal(numbers[i]);
        }
        return (T)Convert.ChangeType(sum, typeof(T));
    }
}

