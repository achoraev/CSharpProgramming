﻿namespace ComparePerformanceOfSqrtLogAndSinus
{
    using System;
    using System.Linq;

    public class Logarithm
    {
        public static void CalculateLogFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }
        }

        public static void CalculateLogDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step)
            {
                Math.Log((double)i);
            }
        }

        public static void CalculateLogDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }
        }
    }
}