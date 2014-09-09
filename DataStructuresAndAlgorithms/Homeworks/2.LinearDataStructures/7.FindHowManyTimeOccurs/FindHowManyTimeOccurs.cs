// Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2 - 2 times
// 3 - 4 times
// 4 - 3 times
namespace FindHowManyTimeOccurs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FindHowManyTimeOccurs
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            SortedDictionary<int, int> occurs = new SortedDictionary<int, int>();

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

            foreach (var item in occurs)
            {
                Console.WriteLine("{0} - {1} times.", item.Key, item.Value);
            }
        }
    }
}