using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareRealNumbers
{
    class ComparePerformance
    {
        static void Main(string[] args)
        {
            SqrtOperations.CalculateSqrtDouble(2d, 10000d, 0.002d);

            SqrtOperations.CalculateSqrtDecimal(2m, 10000m, 0.002m);

            SqrtOperations.CalculateSqrtFloat(2f, 10000f, 0.002f);

            LogMethods.CalculateLogDouble(2d, 10000d, 0.002d);

            LogMethods.CalculateLogDecimal(2m, 10000m, 0.002m);

            LogMethods.CalculateLogFloat(2f, 10000f, 0.002f);

            SinusMethods.CalculateSinDouble(2d, 10000d, 0.002d);

            SinusMethods.CalculateSinDecimal(2m, 10000m, 0.002m);

            SinusMethods.CalculateSinFloat(2f, 10000f, 0.002f);
        }
    }
}
