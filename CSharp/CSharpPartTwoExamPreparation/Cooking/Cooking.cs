using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cooking
{
    static void Main()
    {
        bool isAProductUsed = false;
        int NumberOfRecipeProducts = int.Parse(Console.ReadLine());
        List<string[]> recipeProducts = new List<string[]>();
        decimal[] recipeValues = new decimal[NumberOfRecipeProducts];
        for (int i = 0; i < NumberOfRecipeProducts; i++)
        {
            string[] currentProduct = Console.ReadLine().Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);
            recipeProducts.Add(currentProduct);
            recipeValues[i] = decimal.Parse(currentProduct[0]);
        }

        int numberOfProductsUsed = int.Parse(Console.ReadLine());
        List<string[]> usedProducts = recipeProducts;
        for (int i = 0; i < numberOfProductsUsed; i++)
        {
            string[] currentProduct = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            usedProducts.Add(currentProduct);
        }
        List<string[]> output = new List<string[]>();
        for (int i = 0; i < NumberOfRecipeProducts; i++)
        {
            for (int j = 0; j < usedProducts.Count; j++)
            {
                if (recipeProducts[i][2].ToLower() == usedProducts[j][2].ToLower())
                {
                    decimal usedQuantity = CalculateProductDifferences(recipeProducts[i], usedProducts[j]);
                    decimal recipeMinusUsed = recipeValues[i] - usedQuantity;
                    if (recipeMinusUsed <= 0)
                    {
                        continue;
                    }
                    else
                    {

                        string[] arr = new string[3];
                        string formatQuantity = recipeMinusUsed.ToString("0.00"+":");
                        arr[0] = formatQuantity;
                        arr[1] = recipeProducts[i][1] + ":";
                        arr[2] = recipeProducts[i][2];
                        output.Add(arr);
                    }
                } 
            }
        }
        for (int i = 0; i < output.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(output[i][j]);
            }
            Console.WriteLine();
        }
    }
    static decimal CalculateProductDifferences(string[] recipeProducts, string[] usedProducts)
    {
        string measurementUnit = recipeProducts[1];
        decimal recipeQuantity = decimal.Parse(recipeProducts[0]);
        decimal usedQuantity = decimal.Parse(usedProducts[0]);
        decimal difference = 0;
        if (measurementUnit == usedProducts[1])
        {
            usedQuantity = decimal.Parse(usedProducts[0]);
            difference = recipeQuantity - usedQuantity;
            return difference;
        }
        else
        {
            string usedUnit = usedProducts[1];

            if (measurementUnit == "tbsps")
            {
                if (usedUnit == "tsps")
                {
                    usedQuantity /= 3;
                    difference = recipeQuantity - usedQuantity;
                }
                if (usedUnit == "mls")
                {
                    usedQuantity /= 5;
                    usedQuantity /= 3;
                    difference = recipeQuantity - usedQuantity;
                }
            }
            if (measurementUnit == "ls")
            {
                usedQuantity = usedQuantity / 1000;
                difference = recipeQuantity - usedQuantity;
            }
            if (measurementUnit == "fl ozs")
            {
                if (usedUnit == "cups")
                {
                    usedQuantity *= 8;
                    difference = recipeQuantity - usedQuantity; 
                }
                else if (usedUnit == "tsps")
                {
                    usedQuantity /= 48;
                    usedQuantity *= 8;
                }
                else if (usedUnit == "pts")
                {
                    usedQuantity *= 2;
                    usedQuantity *= 8;
                    difference = recipeQuantity - usedQuantity;
                }
            }
            if (measurementUnit == "tsps")
            {
                if (usedUnit == "mls")
                {
                    usedQuantity /= 5;
                    difference = recipeQuantity - usedQuantity; 
                }
                else if (usedUnit == "tbsps")
                {
                    usedQuantity *= 3;
                    difference = recipeQuantity - usedQuantity;
                }
                else if (usedUnit == "cups")
                {
                    usedQuantity *= 48;
                    difference = recipeQuantity - usedQuantity;
                }
            }
            if (measurementUnit == "gals")
            {
                if (usedUnit == "qts")
                {
                    usedQuantity = usedQuantity / 4;
                    difference = recipeQuantity - usedQuantity; 
                }
                else if (usedUnit == "pts")
                {
                    usedQuantity /= 2;
                    usedQuantity /= 4;
                    difference = recipeQuantity - usedQuantity;
                }
                else if (usedUnit == "cups")
                {
                    usedQuantity /= 2;
                    usedQuantity /= 2;
                    usedQuantity /= 4;
                    difference = recipeQuantity - usedQuantity;
                }
            }
            if (measurementUnit == "pts")
            {
                if (usedUnit == "cups")
                {
                    usedQuantity = usedQuantity / 2;
                    difference = recipeQuantity - usedQuantity; 
                }
                else if (usedUnit == "qts")
                {
                    usedQuantity *= 2;
                    difference = recipeQuantity - usedQuantity;
                }
            }
            if (measurementUnit == "qts")
            {
                usedQuantity = usedQuantity / 2;
                difference = recipeQuantity - usedQuantity;
            }
            if (measurementUnit == "cups")
            {
                usedQuantity = usedQuantity / 48;
                difference = recipeQuantity - usedQuantity;
            }
            if (measurementUnit == "tsps")
            {
                usedQuantity = usedQuantity * 3;
                difference = recipeQuantity - usedQuantity;
            }
            if (measurementUnit == "mls")
            {
                usedQuantity = usedQuantity * 1000;
                difference = recipeQuantity - usedQuantity;
            }
            if (measurementUnit == "cups")
            {
                usedQuantity = usedQuantity / 8;
                difference = recipeQuantity - usedQuantity;
            }
        }
        return usedQuantity;
    }
}

