using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFromLecture
{
    public class CombinationsWithRep
    {
        private int numberOfElements;
        private int elementsInComb;
        private int[] combinations;
        
        public CombinationsWithRep(int numberOfElements, int elementsInComb)
        {
            this.numberOfElements = numberOfElements;
            this.elementsInComb = elementsInComb;
            this.combinations = new int[numberOfElements + 1];
        }

        public void GenerateComb(int startPos)
        {
            if (startPos > this.elementsInComb)
            {
                return;
            }

            for (int i = 0; i <= this.numberOfElements; i++)
            {
                this.combinations[startPos] = i;

                if (startPos == this.elementsInComb)
                {
                    this.Print();
                }

                GenerateComb(startPos + 1);
            }
        }

        private void Print()
        {
            for (int i = 0; i <= this.elementsInComb; i++)
            {
                Console.Write(this.combinations[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
