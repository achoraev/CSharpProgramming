namespace SecondTask
{
    using System;   

    public class ClassPrint
    {
        public static void Main()
        {
            double[] numbers = new double[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 5;
            }

            PrintStatistics(numbers, numbers.Length);            
        }

        public static void PrintStatistics(double[] arrayOfNumbers, int length)
        {
            double minNumber = double.MaxValue;
            Console.WriteLine(PrintMin(arrayOfNumbers, minNumber));

            double maxNumber = double.MinValue;
            Console.WriteLine(PrintMax(arrayOfNumbers, maxNumber));

            double sumOfNumbers = 0;
            Console.WriteLine(PrintAvg(arrayOfNumbers, sumOfNumbers));
        }

        private static double PrintAvg(double[] arrayOfNumbers, double sumOfNumbers)
        {
            for (int k = 0; k < arrayOfNumbers.Length; k++)
            {
                sumOfNumbers += arrayOfNumbers[k];
            }

            return sumOfNumbers / arrayOfNumbers.Length;
        }

        private static double PrintMin(double[] arrayOfNumbers, double minNumber)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] < minNumber)
                {
                    minNumber = arrayOfNumbers[i];
                }
            }

            return minNumber;
        }

        private static double PrintMax(double[] arrayOfNumbers, double maxNumber)
        {
            for (int j = 0; j < arrayOfNumbers.Length; j++)
            {
                if (arrayOfNumbers[j] > maxNumber)
                {
                    maxNumber = arrayOfNumbers[j];
                }
            }

            return maxNumber;
        }
    }
}
