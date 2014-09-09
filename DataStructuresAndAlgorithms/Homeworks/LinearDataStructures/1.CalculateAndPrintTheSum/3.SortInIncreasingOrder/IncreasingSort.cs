using System;
using System.Collections.Generic;
//Write a program that reads a sequence of integers (List<int>) ending with an empty line
//and sorts them in an increasing order.

public class IncreasingSort
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

        List<int> sortedNumbers = increasingSort(sequenceOfNumbers);

        for (int i = 0; i < sortedNumbers.Count; i++)
		{
            Console.WriteLine(sortedNumbers[i]);
		}
    }

    public static List<int> increasingSort(List <int> numbers)
    {        
        List<int> sortedList = new List<int>();        

        while(numbers.Count != 0)
        {
            int indexOfMinElement = minElement(numbers);
            sortedList.Add(numbers[indexOfMinElement]);
            numbers.RemoveAt(indexOfMinElement);            
        }
		
		return sortedList;
    }	

    public static int minElement (List<int> arrayOfNumbers)
    {
        int min = int.MaxValue;
        int index = 0;
        for (int i = 0; i < arrayOfNumbers.Count; i++)
        {
            if (arrayOfNumbers[i] <= min)
            {
                min = arrayOfNumbers[i];
                index = i;
            }
        }
        return index;
    }
}