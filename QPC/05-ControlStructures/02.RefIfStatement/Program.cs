using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RefIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_X = 0;
            const int MAX_X = 20;
            const int MAX_Y = 20;
            const int MIN_Y = 0;
            int x = 3;
            int y = 6;
            Potato potato;
            //... 
            if (potato != null)
            {
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
            bool canVisitCell;
            bool isInRange = x >= MIN_X && x =< MAX_X && MAX_Y >= y && MIN_Y <= y;
            if (canVisitCell && isInRange)
            {
                VisitCell();
            }
        }
        class Potato
        {
            private bool hasBeenPeeled;
            private bool isRotten;
            public Potato(bool hasBeenPeeled, bool isRotten)
            {
                this.hasBeenPeeled = hasBeenPeeled;
                this.isRotten = isRotten;
            }
            public bool HasNotBeenPeeled
            {
                get { return this.hasBeenPeeled; }
            }
            public bool IsRotten
            {
                get { return this.isRotten; }
            }
        }
    }
}
