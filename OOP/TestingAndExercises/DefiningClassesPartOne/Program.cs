using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belot.Common;
using Belot.StefanAI;


public class DoubleList<Pesho, T2>
    where Pesho: class,IDisposable,IComparable,new()
    where T2: new()
{
    private List<Pesho> firstList = new List<Pesho>();
    private List<T2> secondList = new List<T2>();
    
    public void Add(Pesho firstValue, T2 secondValue)
    {
        
        firstList.Add(firstValue);
        secondList.Add(secondValue);
    }
}
namespace DefiningClassesPartOne
{
    public delegate void DelegateExample(string p);
    public class NaGoshoSestraMu
    {
        public void PrintHerName()
        {
            Type t = this.GetType();
            Console.WriteLine(t.Name);
        }

    }
    class Program
    {
        
        static void TestMethod(string p)
        {
            Console.WriteLine(p + "+++");
        }
        static void OtherTest(string g)
        {
            
            Console.WriteLine(g + "***");
        }
        static void Main()
        {
            NaGoshoSestraMu gosho = new NaGoshoSestraMu();
            Type t = gosho.GetType();
            gosho.PrintHerName();
            //int[] arr = new int[] { 24, 34, 2, 5, 7, 12, 65, 5 };
            //var selected = from num in arr
            //               from numTwo in arr
            //               where num % 4 == 0
            //               where num != numTwo && num % 2 == 0
            //               select new { Num = num , NumTwo = numTwo};
            //var sorted = from n in arr
            //             orderby n descending
            //             select n;
            //foreach (var item in sorted)
            //{
            //    Console.Write(item + " ");
            //}
            ////foreach (var item in selected)
            ////{
            ////    Console.Write("{0} -> {1}",item.Num,item.NumTwo);
            ////}
            //DelegateExample d = delegate(string str)
            //    {
            //        Console.WriteLine(str);
            //    };
            //d("ei!");
            //var myCar = new { speed = 190, make = "Mercedes", model = "S 63" };
            //decimal speed = myCar.speed;
            //Console.WriteLine(myCar);
            //IPlayer player = new Player();
            //player.PlayCard();
            //string a = "abcd";
            //string b = "abccccccc";
            //string min = Minimal<string>(a,b);
            //Console.WriteLine(min);
            //CheckBitAtPosition bits = new CheckBitAtPosition();

            //int res = bits[2];
            //Console.WriteLine(res);
            //HumanPlayer first = new HumanPlayer();
            //HumanPlayer second = new HumanPlayer();
            //string sum = first + second;
            //Console.WriteLine(sum);
            
            //DoubleList<string, int> myList = new DoubleList<string, int>();
        }
        public static T Minimal<T>(T first, T second)
            where T : IComparable
        {
            if (first.CompareTo(second) > 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}
namespace Gosho
{
    public class NaGoshoSestraMu
    {
        public void PrintHerName()
        {
            string type = Convert.ToString(this);
            Console.WriteLine(type);
        }
        
    }
}
