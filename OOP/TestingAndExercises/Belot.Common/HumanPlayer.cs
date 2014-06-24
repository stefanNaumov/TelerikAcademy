using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belot.Common
{
    public class HumanPlayer: IPlayer
    {
        private string points;
        public string Name
        {
            get { return "Human player"; }
        }

        public string Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public void PlayCard()
        {
            Console.WriteLine("Human player played a card!!!"); ;
            var player = new InternalPlayerTest();
            player.Decision();
            
        }
        public static string operator +(HumanPlayer a, HumanPlayer b)
        {
            HumanPlayer player = new HumanPlayer();
            player.Points = a.points + b.points;
            return player.points;
        }
        
    }
}
