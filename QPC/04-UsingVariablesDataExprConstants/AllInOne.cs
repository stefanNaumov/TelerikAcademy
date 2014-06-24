using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_UsingVariablesDataExprConstants
{
    class AllInOne
    {
        static void Main(string[] args)
        {

        }
        //Task one
        public class Size
        {
            public double width, height;
            public Size(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
        }

        public static Size GetRotatedSize(Size size,
            double angle)
        {
            double width = Math.Abs(Math.Cos(angle)) * size.width +
                Math.Abs(Math.Sin(angle)) * size.height;
            double height = Math.Abs(Math.Sin(angle)) * size.width +
                Math.Abs(Math.Cos(angle) * size.height);
            Size newSize = new Size(width, height);

            return newSize;
        }
        //Task two
        public void PrintStatistics(double[] arr, int count)
        {
            double max = double.MinValue; 
            double tmp;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            //PrintMax(max);

            tmp = 0;
            max = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < max)
                {
                    max = arr[i];
                }
            }
            //PrintMin(max);

            tmp = 0;
            for (int i = 0; i < count; i++)
            {
                tmp += arr[i];
            }
            //PrintAvg(tmp/count);
        }
    }

}



