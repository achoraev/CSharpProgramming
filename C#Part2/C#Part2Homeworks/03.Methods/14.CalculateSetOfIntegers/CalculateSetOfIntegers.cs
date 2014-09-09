using System;
using System.Collections.Generic;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

class CalculateSetOfIntegers
{
    static void Main()
    {        
        List<long> numbers = new List<long> { 5, 5, 9, -10, 8, 7 , 132, 9, -100, 1 };
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write("{0} ",numbers[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Мinimal number is: {0}", CalculateMinimum(numbers));
        Console.WriteLine("Maximal number is: {0}", CalculateMaximum(numbers));
        Console.WriteLine("Average number is: {0}", CalculateAverage(numbers));
        Console.WriteLine("Sum of numbers is: {0}", CalculateSum(numbers));
        Console.WriteLine("Product of numbers is: {0}", CalculateProduct(numbers));       
    }

    private static long CalculateSum(List<long> listNumbers)
    {
        long result = 0;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            result += listNumbers[i];
        }
        return result;
    }

    private static long CalculateProduct(List<long> listNumbers)
    {
        long result = 1;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            result *= listNumbers[i];
        }
        return result;
    }

    private static long CalculateAverage(List<long> listNumbers)
    {
        long result = 0;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            result += listNumbers[i];
        }
        result /= listNumbers.Count;
        return result;
    }

    private static long CalculateMinimum(List<long> listNumbers)
    {
        long min = long.MaxValue;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            if (listNumbers[i] < min)
            {
                min = listNumbers[i];
            }
        }
        return min;
    }

    private static long CalculateMaximum(List<long> listNumbers)
    {
        long max = long.MinValue;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            if (listNumbers[i] > max)
            {
                max = listNumbers[i];
            }
        }
        return max;
    }
}

