using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MostPopularFriend
{
    class Program
    {
        static void Main()
        {
            int numberOfUsers = int.Parse(Console.ReadLine());
            bool[,] adjMatrix = new bool[numberOfUsers, numberOfUsers];
            int maxCounter = 0;

            for (int i = 0; i < numberOfUsers; i++)
            {
                
                string currentUser = Console.ReadLine();

                for (int j = 0; j < numberOfUsers; j++)
                {
                    if (currentUser[j] == 'Y')
                    {
                        adjMatrix[i, j] = true;
                    }
                }
            }
            int[] friendsCounter = new int[numberOfUsers];

            for (int i = 0; i < numberOfUsers; i++)
            {
                int tempCounter = 1;
                for (int j = 0; j < numberOfUsers; j++)
                {
                    bool areFriends = false;
                    if (i == j)
                    {
                        continue;
                    }
                    if (adjMatrix[i,j])
                    {
                        areFriends = true;
                    }
                    else
                    {
                        for (int k = 0; k < numberOfUsers; k++)
                        {
                            if ((k != i) && (k != j) && adjMatrix[i,k] && adjMatrix[j,k])
                            {
                                areFriends = true;
                                break;
                            }
                        }
                    }
                    if (areFriends)
                    {
                        tempCounter++;

                    }
                }
                if (tempCounter >= maxCounter)
                {
                    maxCounter = tempCounter;
                }
            }
            //Array.Sort(friendsCounter);
            Console.WriteLine(maxCounter - 1);
        }
    }
}
