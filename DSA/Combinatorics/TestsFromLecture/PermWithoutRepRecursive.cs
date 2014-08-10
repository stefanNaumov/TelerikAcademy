using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFromLecture
{
    public class PermWithoutRepRecursive
    {
        private int numberOfElements;
        private int[] permutations;
        private bool[] used;

        public PermWithoutRepRecursive(int numberOfelements)
        {
            this.numberOfElements = numberOfelements;
            this.permutations = new int[this.numberOfElements];
            this.used = new bool[this.numberOfElements + 1];
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
                if (!this.used[k])
                {
                    this.used[k] = true;
                    this.permutations[startPos] = k;
                    GeneratePerm(startPos + 1);
                    this.used[k] = false;
                }
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
