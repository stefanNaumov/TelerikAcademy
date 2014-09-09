using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableCollection
{
    public class SortableCollection
    {
        private IList<int> collection;

        public SortableCollection(IList<int> collection)
        {
            this.collection = collection;
        }

        public void SelectionSort()
        {
            for (int i = 0; i < this.collection.Count - 1; i++)
            {
                int min = i;
                for (int j = 0; j < collection.Count; j++)
                {
                    if (this.collection[j] < this.collection[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = this.collection[i];
                    this.collection[i] = this.collection[min];
                    this.collection[min] = temp;
                }
            }
        }

        public void BubbleSort()
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 1; i < this.collection.Count; i++)
                {
                    if (this.collection[i - 1] > this.collection[i])
                    {
                        int temp = this.collection[i - 1];
                        this.collection[i - 1] = this.collection[i];
                        this.collection[i] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped == true);
        }

        public void InsertionSort()
        {
            for (int i = 1; i < this.collection.Count; i++)
            {
                int movingPos = i;
                while (movingPos > 0 && this.collection[movingPos - 1] > this.collection[movingPos])
                {
                    int temp = this.collection[movingPos - 1];
                    this.collection[movingPos - 1] = this.collection[movingPos];
                    this.collection[movingPos] = temp;
                    movingPos--;
                }
            }
        }
    }
}
