// 1.Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
// Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
// -2.5 - 2 times
// 3 - 4 times
// 4 - 3 times
namespace CountDoubleValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountDoubleValues
    {
        public static void Main()
        {
            double[] doubleNumbers = new double[9] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            IDictionary<double, int> numbersCount = new SortedDictionary<double, int>();
            CountWords(doubleNumbers, numbersCount);
        }

        private static void CountWords(double[] numbers, IDictionary<double, int> numbersCount)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                if (numbersCount.ContainsKey(numbers[i]))
                {
                    count = numbersCount[numbers[i]] + 1;
                }
                numbersCount[numbers[i]] = count;
            }

            foreach (var pair in numbersCount)
            {
                Console.WriteLine("{0} --> {1} times", pair.Key, pair.Value);
            }
        }
    }
}