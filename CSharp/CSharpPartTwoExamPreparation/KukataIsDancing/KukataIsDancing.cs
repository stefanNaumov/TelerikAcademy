using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KukataIsDancing
{
    static void Main()
    {
        int numberOfDances = int.Parse(Console.ReadLine());
        string[,] danceCube = new string[3,3];
        

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                if((r == 0 && c == 0) || (r == 0 && c == 2) || (r == 2 && c == 0) ||(r == 2 && c == 2))
                {
                    danceCube[r, c] = "RED";
                }
                if (r == 1 && c == 1)
                {
                    danceCube[r, c] = "GREEN";
                }
                else if((r == 0 && c == 1) || (r == 1 && c == 0) || (r == 1 && c == 2) || (r == 2 && c == 1))
                {
                    danceCube[r, c] = "BLUE";
                }
            }
        }
        List<string> squares = new List<string>();
        for (int i = 0; i < numberOfDances; i++)
        {
            string currDance = Console.ReadLine();
            squares.Add(DancePath(danceCube,currDance));
        }

        for (int i = 0; i < squares.Count; i++)
        {
            Console.WriteLine(squares[i]);
        }

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.Write(danceCube[i, j]);
        //    }
        //    Console.WriteLine();
        //}
    }
    static string DancePath(string[,] danceCube, string currDance)
    {
        
        bool goLeft = false;
        bool goRight = false;
        bool goUp = true;
        bool goDown = false;
        int currentRow = 1;
        int currentCol = 1;

        for (int i = 0; i < currDance.Length; i++)
        {
            switch (currDance[i])
            {
                case 'L':
                    {
                        if (goUp == true)
                        {
                            goLeft = true;
                            goUp = false;
                            goDown = false;
                            goRight = false;
                            break;
                        }
                        if(goLeft == true)
                        {
                            goDown = true;
                            goLeft = false;
                            goRight = false;
                            goUp = false;
                            break;
                        }
                        if(goDown == true)
                        {
                            goRight = true;
                            goLeft = false;
                            goDown = false;
                            goUp = false;
                            
                            break;
                        }
                        if(goRight == true)
                        {
                            goUp = true;
                            goLeft = false;
                            goDown = false;
                            goRight = false;
                            break;
                        }
                        break;
                    }
                case 'R':
                    {
                        if(goUp == true)
                        {
                            goRight = true;
                            goDown = false;
                            goUp = false;
                            goLeft = false;
                            break;
                        }
                        if(goLeft == true)
                        {
                            goUp = true;
                            goLeft = false;
                            goRight = false;
                            goDown = false;
                            break;
                        }
                        if(goDown == true)
                        {
                            goLeft = true;
                            goRight = false;
                            goDown = false;
                            goUp = false;
                            
                            break;
                        }
                        if(goRight == true)
                        {
                            goDown = true;
                            goRight = false;
                            goLeft = false;
                            goUp = false;
                            break;
                        }
                        break;
                    }
                case 'W':
                    {
                        if(goLeft)
                        {
                            if (currentCol > 0)
                            {
                                currentCol--;
                            }
                            else
                            {
                                currentCol = 2;
                            }
                            break;
                        }
                        if(goDown)
                        {
                            if (currentRow < 2)
                            {
                                currentRow++;
                            }
                            else
                            {
                                currentRow = 0;
                            }
                            break;
                        }
                        if(goRight)
                        {
                            if (currentCol < 2)
                            {
                                currentCol++;
                            }
                            else
                            {
                                currentCol = 0;
                            }
                            break;
                        }
                        if(goUp)
                        {
                            if (currentRow > 0)
                            {
                                currentRow--;
                            }
                            else
                            {
                                currentRow = 2;
                            }
                            break;
                        }
                        break;
                    }
            }
        }
        return danceCube[currentRow, currentCol];

    }
}

