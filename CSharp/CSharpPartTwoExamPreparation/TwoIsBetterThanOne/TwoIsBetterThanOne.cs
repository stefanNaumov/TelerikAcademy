using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace TwoIsBetterThanOne
{
    class TwoIsBetterThanOne
    {
        static void Main()
        {
            
            string numbers = Console.ReadLine();
            string[] numberArr = numbers.Split(' ');

            
            
            BigInteger A = BigInteger.Parse(numberArr[0]);
            BigInteger B = BigInteger.Parse(numberArr[1]);

                           
           
            long luckyNumbers = 0;

            for (BigInteger i = A+1; i < B; i++)
            {
                string currNumber = i.ToString();
                bool isLuckynumber = false;

                int firstSum = 0;
                int secSum = 0;
                bool isEqualSum = false;
                if (i > 9)
                {
                    for (int h = 0; h < currNumber.Length/2; h++)
                    {
                        
                        firstSum += Convert.ToInt32(currNumber[h])-48;
                    }
                    for (int h2 = currNumber.Length/2; h2 < currNumber.Length ; h2++)
                    {
                        secSum += Convert.ToInt32(currNumber[h2])-48;
                    }
                    if (firstSum == secSum)
                    {
                        isEqualSum = true;
                    }
                }
                else if (currNumber.Length % 2 != 0)
                {
                    bool areAllThree = true;
                    
                    for (int a = 0; a < currNumber.Length; a++)
                    {
                        if (currNumber[a] != '3')
                        {
                            areAllThree = false;
                            break;
                        }
                    }
                    bool areAllFive = true;

                    for (int b = 0; b < currNumber.Length; b++)
                    {
                        if (currNumber[b] != '5')
                        {
                            areAllFive = false;
                            break;
                        }
                    }
                    if (areAllThree == true)
                    {
                        luckyNumbers++;
                    }
                    if (areAllFive == true)
                    {
                        luckyNumbers++;
                    }
                }


                if (isEqualSum && i > 9)
                {

                    for (int j = 0; j < currNumber.Length; j++)
                    {
                        if (currNumber[j] == '3' || currNumber[j] == '5')
                        {
                            isLuckynumber = true;
                        }
                        else
                        {
                            isLuckynumber = false;
                            break;
                        }
                    }
                    if (isLuckynumber == true)
                    {
                        luckyNumbers++;
                    }
                }
                else if (i < 10)
                {
                    if (i == 3 || i == 5)
                    {
                        luckyNumbers++;
                    }
                }
            }
            string listOfNumbers = Console.ReadLine();
            int percentage = int.Parse(Console.ReadLine());
            string[] listofNumbersArr = listOfNumbers.Split(',');
            int[] listOfInts = new int[listofNumbersArr.Length];
            for (int i = 0; i < listofNumbersArr.Length; i++)
            {
                listOfInts[i] = int.Parse(listofNumbersArr[i]);
            }
            Array.Sort(listOfInts);

            int result = listOfInts[(percentage * listofNumbersArr.Length - 1) / 100];
            
            Console.WriteLine(luckyNumbers);
            Console.WriteLine(result);
        }
    }
}
