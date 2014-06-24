using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListT
{
    public class GenericList<T>
    {

        private T[] genericList;
        private int position = 0;
        private int capacity;
        //constructor
        public GenericList(int capacity)
        {
            this.genericList = new T[capacity];
            this.capacity = capacity;
        }
        //couple of methods
        public int ListLength
        {
            get { return this.genericList.Length; }
        }
        //get elements by index
        public T this[int index]
        {
            get 
            {
                if (index < 0 || index >= genericList.Length)
                {
                    string listSize = genericList.Length.ToString() + "!";
                    throw new IndexOutOfRangeException("Index must be greater or equal to zero and less than " + listSize);
                }
                return genericList[index];
            }
        }
        public int GetElementByValue(T element)
        {
            int elementIndex = -1; // if such element is not found the method will return -1
            for (int i = 0; i < genericList.Length; i++)
            {
                if (genericList[i].Equals(element))
                {
                    elementIndex = i;
                }
            }
            return elementIndex;
        }
        public void AddElement(T element)
        {
            if (position == genericList.Length)
            {
                AutoGrow();
            }
            if (element == null)
            {
                throw new ArgumentNullException("Cannot add an element with value null!");
            }
           
            genericList[position] = element;
            position++; 
        }
        public void RemoveElement(int positionToRemove)
        {
            if (positionToRemove < 0 || positionToRemove >= position)
            {
                string listSize = genericList.Length.ToString() + "!";
                throw new IndexOutOfRangeException("Index must be greater or equal to zero and less than " + listSize);
            }

            T[] newList = new T[genericList.Length - 1];
            int tempPos = 0;
            for (int i = 0; i < genericList.Length; i++)
            {
                if (tempPos == positionToRemove)
                {
                    i++;                        //this will pass the position we want to remove - not add it to the new array
                }
                newList[tempPos] = genericList[i];
                tempPos++;
            }
            genericList = newList;
            position--;
        }
        public void InsertAt(T element,int insertPosition)
        {
            //if (position == genericList.Length)
            //{
            //    AutoGrow();
            //}
            if (insertPosition < 0 || insertPosition >= genericList.Length)
            {
                string listSize = genericList.Length.ToString() + "!";
                throw new IndexOutOfRangeException("Index must be greater or equal to zero and less than " + listSize);
            }
            if (element == null)
            {
                throw new ArgumentNullException("Cannot insert element with null value!");
            }
            T[] newArray = new T[genericList.Length + 1];
            int tempPosition = 0;

            for (int i = 0; i < genericList.Length; i++)
            {
                if (tempPosition == insertPosition)
                {
                    newArray[tempPosition] = element;
                    tempPosition++;
                }
                newArray[tempPosition] = genericList[i];
                tempPosition++;
            }
            genericList = newArray;
            position++;
        }
        public void AutoGrow()
        {
            T[] newArr = new T[genericList.Length * 2];

            for (int i = 0; i < genericList.Length; i++)
            {
                newArr[i] = genericList[i];
            }
            genericList = newArr;
        }
        public void ClearList()
        {
            position = 0;
            genericList = new T[capacity];
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (T item in genericList)
            {
                builder.Append(item);
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
