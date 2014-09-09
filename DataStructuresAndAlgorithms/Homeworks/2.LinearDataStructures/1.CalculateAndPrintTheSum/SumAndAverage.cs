// 1.Write a program that reads from the console a sequence of positive integer numbers. 
// The sequence ends when empty line is entered. Calculate and print the sum and average 
// of the elements of the sequence. Keep the sequence in List<int>.
using System;
using System.Collections.Generic;

public class SumAndAverage
{
    static void Main()
    {
        List<int> sequenceOfNumbers = new List<int>();
		
		Console.WriteLine("Enter positive integer: ");
        while (true) 
		{
            string input = Console.ReadLine();
            if (input == string.Empty)
            {
                break;
            }
            else
            {
                int number = int.Parse(input);
                sequenceOfNumbers.Add(number);
            }            
		}

        Console.WriteLine("The sum is: {0}", SumOfNumbers(sequenceOfNumbers));
        Console.WriteLine("The average is: {0}", AverageOfNumbers(sequenceOfNumbers));
	}

    public static long SumOfNumbers(List<int> numbers)
    {
        long sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static long AverageOfNumbers(List<int> numbers)
    {
        long sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        if (numbers.Count > 0)
        {
            return sum / numbers.Count;
        }
        else
        {
            return sum;
        }        
    }
}