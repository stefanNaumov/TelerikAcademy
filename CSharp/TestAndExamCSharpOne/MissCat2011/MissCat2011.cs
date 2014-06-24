using System;


namespace MissCat2011
{
    class MissCat2011
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());  //votes
            int[] cats = new int[11];
            for (int i = 1; i < N; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                for (int cat = 0; cat < cats.Length; cat++)
                {
                    if (vote == cat + 1)
                    {
                        cats[cat]++;
                        break;
                    }
                }
            }
            int winnerCat = 0;
            int winnerCatPosition = 0;
            for (int i = 0; i < cats.Length; i++)
            {
                if (cats[i] > winnerCat)
                {
                    winnerCat = cats[i];
                    winnerCatPosition = i + 1;
                }
            }
            Console.WriteLine(winnerCatPosition);
        }
    }
}
