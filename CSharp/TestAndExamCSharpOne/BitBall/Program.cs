using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBall
{
    class Program
    {
        static void Main()
        {
            int[,] topTeamField = new int[8, 8];
            int[,] bottomTeamField = new int[8, 8];
            int topTeamScore = 0;
            int bottomTeamScore = 0;

            //fill Top Team

            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    topTeamField[row, col] = (number >> 7 - col) & 1;
                }
            }

            //fill Bottom Team

            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    bottomTeamField[row, col] = (number >> 7 - col) & 1;
                }
            }
            //Calculate fouls

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (topTeamField[row, col] == 1 && bottomTeamField[row, col] == 1)
                    {
                        topTeamField[row, col] = 0;
                        bottomTeamField[row, col] = 0;
                    }
                }
            }
            //check Top Team Score

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    int b = 0;
                    
                    if (topTeamField[row, col] == 1)
                    {
                        bool isTopTeamScoring = true;
                        b = row;
                        for (int i = b+1; i < 8; i++)
                        {
                            if (topTeamField[i, col] != 0 || bottomTeamField[i, col] != 0)
                            {
                                isTopTeamScoring = false;
                            }
                            if (i == 7 && isTopTeamScoring == true)
                            {
                                topTeamScore++;
                            }
                        }
                    }
                    if (topTeamField[row, col] == 1 && row == 7)
                    {
                        topTeamScore++;
                    }
                }
            }
            //check Bottom Team Score

            for (int col = 0; col < 8; col++)
            {
                for (int row = 7; row >= 0; row--)
                {
                    int t = 0;
                    if (bottomTeamField[row, col] == 1)
                    {
                        bool isBottomTeamScoring = true;
                        t = row;

                        for (int i = t - 1; i >= 0; i--)
                        {
                            if (bottomTeamField[i, col] != 0 || topTeamField[i, col] != 0)
                            {
                                isBottomTeamScoring = false;
                            }
                            if (i == 0 && isBottomTeamScoring == true)
                            {
                                bottomTeamScore++;
                            }
                        }
                    }
                    if (bottomTeamField[row, col] == 1 && row == 0)
                    {
                        bottomTeamScore++;
                    }
                }
            }

            Console.WriteLine("{0}:{1}",topTeamScore,bottomTeamScore);
        }
    }
}
