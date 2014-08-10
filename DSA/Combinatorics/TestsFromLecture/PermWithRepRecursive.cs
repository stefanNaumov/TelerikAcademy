using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFromLecture
{
    public class PermWithRepRecursive
    {
        private int numberOfElements;
        private int[] permutations;

        public PermWithRepRecursive(int numOfElements)
        {
            this.numberOfElements = numOfElements;
            this.permutations = new int[numberOfElements + 1];
        }

        public void GeneratePerm(int startPos)
        {
            if (startPos >= this.numberOfElements)
            {
                this.Print();

                return;
            }

            for (int k = 0; k < this.numberOfElements; k++)
            {
                this.permutations[startPos] = k;
                GeneratePerm(startPos + 1);
            }
        }

        private void Print()
        {
            for (int i = 0; i < this.numberOfElements; i++)
            {
                Console.Write(this.permutations[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
