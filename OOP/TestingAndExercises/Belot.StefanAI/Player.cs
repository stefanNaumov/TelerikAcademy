using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belot.Common;

namespace Belot.StefanAI
{
    public class Player: IPlayer
    {
        public string Name
        {
            get { return "Stefan player"; }
        }

        public string Points
        {
            get { throw new NotImplementedException(); }
        }

        public void PlayCard()
        {
            Console.WriteLine("Stefan player played a card!");
        }
    }
}
