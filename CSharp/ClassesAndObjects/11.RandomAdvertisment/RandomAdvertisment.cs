using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisment
{
    public class RandomAdvertisment
    {
        
        
        public static Random ad = new Random();
        
        static void Main()
        {
            string[] randomFrases = new string[] {"This product is excellent","This is an awesome product",
            "I use this products all the time","This is the best product from this category"};
            string[] randomEvents = new string[] {"I feel better now","I managed to get better","It made a miracle for me",
            "I can't beleive it but I feel great","Try it yourself.I am very satisfied with it"};
            string[] AutorFirstName = new string[] {"Dyana","Petya","Stela","Elena","Katya" };
            string[] AutorSecondName = new string[] { "Ivanova", "Petrova", "Kirova" };
            string[] city = new string[] {"Sofia","Plovdiv","Kardzhali","Haskovo","Burgas","Varna" };
        
            string advertismentFrase = randomFrases[randomPos(randomFrases)] ;
            string advertismentEvent = randomEvents[randomPos(randomFrases)];
            string adAutorFirstName = AutorFirstName[randomPos(AutorFirstName)];
            string adAutorSecondName = AutorSecondName[randomPos(AutorSecondName)];
            string adCity = city[randomPos(city)];
            Console.WriteLine(advertismentFrase + "." + advertismentEvent + "." + adAutorFirstName + " " + adAutorSecondName + " - " + adCity);
        
        }

        public static int randomPos(string[] arr)
        {

            int randomArrPos = ad.Next(arr.GetLength(0));
            return randomArrPos;
        }

    }
}
