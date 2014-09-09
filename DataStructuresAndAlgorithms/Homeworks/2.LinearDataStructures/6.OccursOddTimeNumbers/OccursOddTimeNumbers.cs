// 6.Write a program that removes from given sequence all numbers that occur odd number of times. 
// Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} {5, 3, 3, 5}
using System;
using System.Collections.Generic;
using System.Linq;

class OccursOddTimeNumbers
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        Dictionary<int, int> occurs = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!occurs.ContainsKey(numbers[i]))
            {
                occurs.Add(numbers[i], 1);
            }
            else
            {
                occurs[numbers[i]]++;
            }
        }

        Console.Write("Result: ");
        var result = numbers.Where(x => occurs[x] % 2 == 0);

        foreach (int element in result)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();		
    }
}