// 3. Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.
namespace ComparePerformanceOfSqrtLogAndSinus
{
    using System;    
    using System.Globalization;    
    using System.Threading;

    public class Test
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Sqrt.CalculateSqrtDouble(2d, 10000d, 0.002d);

            Sqrt.CalculateSqrtDecimal(2m, 10000m, 0.002m);

            Sqrt.CalculateSqrtFloat(2f, 10000f, 0.002f);

            Logarithm.CalculateLogDouble(2d, 10000d, 0.002d);

            Logarithm.CalculateLogDecimal(2m, 10000m, 0.002m);

            Logarithm.CalculateLogFloat(2f, 10000f, 0.002f);

            Sinus.CalculateSinDouble(2d, 10000d, 0.002d);

            Sinus.CalculateSinDecimal(2m, 10000m, 0.002m);

            Sinus.CalculateSinFloat(2f, 10000f, 0.002f);
        }
    }
}