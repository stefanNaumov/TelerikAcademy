using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        long numberOfPassangers = long.Parse(Console.ReadLine());
        long numberOfTeaDrinkers = long.Parse(Console.ReadLine());
        long numberOfCoffeeDrinkers = numberOfPassangers - numberOfTeaDrinkers;

        bool[] passangers = new bool[numberOfPassangers + 1];   //true for Tea false for Coffee
        bool[] visited = new bool[numberOfPassangers + 1];

        for (int i = 0; i < numberOfTeaDrinkers; i++)
        {
            long current = long.Parse(Console.ReadLine());
            passangers[current] = true;
        }

        long timeCounter = 0;
        long stuardessPosition = 0;
        long drinksOnFlask = 0;
        
        while (true)
        {
            if(numberOfTeaDrinkers > 0)
            {
                if(stuardessPosition == 0)
                {
                    drinksOnFlask = numberOfTeaDrinkers % 7;
                    timeCounter += 47;
                }
                
               
                while (true)
                {
                    if(drinksOnFlask <= 0 && numberOfTeaDrinkers > 0)
                    {
                        timeCounter += stuardessPosition;
                        stuardessPosition = 0;
                        break;
                    }
                    else
                    {
                        stuardessPosition++;
                        timeCounter += 1;
                        if (passangers[stuardessPosition] == true && visited[stuardessPosition] == false)
                        {
                            numberOfTeaDrinkers--;
                            drinksOnFlask--;
                            timeCounter += 4;
                            visited[stuardessPosition] = true;
                            
                        } 
                    }
                    if(numberOfTeaDrinkers == 0)
                    {
                        break;
                    }
                }
            }

            else if(numberOfTeaDrinkers == 0 && numberOfCoffeeDrinkers > 0)
            {
                if (stuardessPosition == 0)
                {
                    timeCounter += 47;
                    if (numberOfCoffeeDrinkers > 7)
                    {
                        drinksOnFlask = numberOfCoffeeDrinkers % 7;
                    }
                    else
                    {
                        drinksOnFlask = numberOfCoffeeDrinkers;
                    }

                }
                while (true)
                {
                    if (drinksOnFlask <= 0 && numberOfCoffeeDrinkers > 0)
                    {
                        timeCounter += stuardessPosition;
                        stuardessPosition = 0;
                        break;
                    }
                    else
                    {
                        stuardessPosition++;
                        timeCounter += 1;

                        if(passangers[stuardessPosition] == false && visited[stuardessPosition] == false)
                        {
                            numberOfCoffeeDrinkers--;
                            drinksOnFlask--;
                            timeCounter += 4;
                            visited[stuardessPosition] = true;
                        }
                    }
                    if(numberOfCoffeeDrinkers == 0)
                    {
                        
                        timeCounter += stuardessPosition;
                        
                        Console.WriteLine(timeCounter);
                        return;
                    }
                }
            }
        }
    }
}

