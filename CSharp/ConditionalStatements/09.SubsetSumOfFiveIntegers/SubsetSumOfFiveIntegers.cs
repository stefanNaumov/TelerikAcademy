using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SubsetSumOfFiveIntegers
{
    class SubsetSumOfFiveIntegers
    {
        static void Main()
        {
            int[] intArray = new int[5];

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("Enter number {0}",i+1);
                intArray[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < intArray.Length-1; i++)
            {
                
                for (int j = i+1; j < intArray.Length; j++)
                {
                    
                    if (intArray[i] + intArray[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0",intArray[i],intArray[j]);
                    }
                    
                    for (int k = j+1; k < intArray.Length; k++)
                    {
                        if (intArray[i] + intArray[j] + intArray[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0",intArray[i],intArray[j],intArray[k]);
                        }
                        
                        for (int m = 0; m < intArray.Length; m++)
                        {
                            if (intArray[i] + intArray[j] + intArray[k] + intArray[m] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0",intArray[i],intArray[j],intArray[k],intArray[m]);
                            }
                        }
                    }
                }
            }

        }
    }
}
