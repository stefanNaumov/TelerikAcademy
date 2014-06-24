using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main()
        {
            string firstCard = Console.ReadLine();
            string secondCard = Console.ReadLine();
            string thirdCard = Console.ReadLine();
            string fourthCard = Console.ReadLine();
            string fifthCard = Console.ReadLine();
            string[] cards = new string[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard };
            
            string tempForAllEqual = firstCard;

            if (secondCard == tempForAllEqual && thirdCard == tempForAllEqual && fourthCard == tempForAllEqual &&
                fifthCard == tempForAllEqual)
            {
                Console.WriteLine("Impossible");
            }

            else if ((firstCard == secondCard && secondCard == thirdCard && thirdCard == fourthCard) ^
                (secondCard == thirdCard && thirdCard == fourthCard && fourthCard == fifthCard) ^
                (firstCard == thirdCard && thirdCard == fourthCard && fourthCard == fifthCard) ^
                (firstCard == secondCard && secondCard == fourthCard && fourthCard == fifthCard) ^
                (firstCard == secondCard && secondCard == thirdCard && thirdCard == fifthCard)
                )
            {
                Console.WriteLine("Four of a Kind");
            }
            else
            {
                bool fullHouse = false;
                string firstEqualTwoPos = "";
                string secondEqualPos = "";
                for (int first = 0; first < cards.Length - 1; first++)
                {
                    
                    for (int second = first + 1; second < cards.Length; second++)
                    {
                        if (cards[first] == cards[second])
                        {
                            if (firstEqualTwoPos == "")
                            {
                                firstEqualTwoPos = cards[first];
                            }
                            else
                            {
                                secondEqualPos = cards[first];
                            }
                        }
                    }
                }
                if ((firstEqualTwoPos != secondEqualPos) && (firstEqualTwoPos != "")&&(secondEqualPos != ""))
                {
                    fullHouse = true;
                }

                if (fullHouse == true)
                {
                    Console.WriteLine("Full House");
                }
                else if (((firstEqualTwoPos != "") && (secondEqualPos == "")) || ((firstEqualTwoPos == "") && (secondEqualPos != "")))
                {
                    Console.WriteLine("One Pair");
                }
            }

        }
        
    }
}
