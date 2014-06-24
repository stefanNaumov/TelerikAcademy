using System;

namespace Methods
{
    class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }
            double sidesSumHalf = (a + b + c) / 2;
            double area = Math.Sqrt(
                sidesSumHalf *
                (sidesSumHalf - a) *
                 (sidesSumHalf - b) *
                 (sidesSumHalf - c));
            return area;
        }

        static string ConvertNumberToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid number!");
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Input array cannot be null!");
            }
            if (elements.Length == 0)
            {
                throw new ArgumentException("There must be at least one element!");
            }
            int maxValue = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }
            return maxValue;
        }

        static void PrintNumberWithPrecisionToTwo(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }
        static void PrintNumberAsPercent(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }
        static void PrintNumberWithPrecisionEight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static bool CheckLineIsHorizontal(double x1, double x2)
        {
            bool isHorizontal = (x1 == x2);

            return isHorizontal;
        }

        public static bool CheckLineIsVertical(double y1, double y2)
        {
            bool isVertical = (y1 == y2);

            return isVertical;
        }

        public static double CalcDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }



        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(ConvertNumberToString(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumberWithPrecisionToTwo(1.3);
            PrintNumberAsPercent(0.75);
            PrintNumberWithPrecisionEight(2.30);

            bool horizontal = CheckLineIsHorizontal(3, 3);
            bool vertical = CheckLineIsVertical(-1, 2.5);
            Console.WriteLine(CalcDistanceBetweenTwoPoints(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.PersonalInfo = new PersonalInformation("17.03.1992", "Sofia");

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.PersonalInfo = new PersonalInformation("03.11.1993", "Varna", "gamer");
            
            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
