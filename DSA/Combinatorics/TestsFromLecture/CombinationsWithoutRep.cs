using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFromLecture
{
    public class CombinationsWithoutRep
    {
        private int numberOfElements;
        private int elementsInCombination;
        private int[] combinations;
        
        public CombinationsWithoutRep(int numOfElements, int elementsInComb)
        {
            this.numberOfElements = numOfElements;
            this.elementsInCombination = elementsInComb;
            this.combinations = new int[numOfElements + 1];
        }

        public void GenerateComb(int startPos, int afterPos)
        {
            if (startPos > this.elementsInCombination)
            {
                this.Print();
                return;
            }

            for (int i = afterPos + 1; i <= this.numberOfElements; i++)
            {
                this.combinations[startPos - 1] = i;

                if (startPos == this.elementsInCombination)
                {
                    this.Print();
                }
                GenerateComb(startPos + 1, i);
            }
        }

        private void Print()
        {
            for (int i = 0; i < this.elementsInCombination; i++)
            {
                Console.Write(this.combinations[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
