namespace LambdaЕxpressionWithInts
{
    using System;    
    using System.Linq;
    //6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
    //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

    public class LambdaЕxpressionWithInts
    {
        static void Main()
        {
            int [] numbers = new int[80];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + i;
            }

            Console.WriteLine("Select with Lambda");
            var selectedItem = numbers.Where(x => x % 21 == 0);
            foreach (var number in selectedItem)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Select with LINQ");
            var selectedItemLinq = from number in numbers
                                   where number % 21 == 0
                                   select number;
            foreach (var number in selectedItem)
            {
                Console.WriteLine(number);
            }
        }
    }
}
