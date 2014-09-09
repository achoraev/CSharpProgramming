namespace IEnumerable
{
    using System;
    using System.Collections.Generic;
    //2.Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

    public static class IEnumerableClass
    {
        public static T Sum<T>(this IEnumerable<T> input)
            where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in input)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input)
            where T : IComparable
        {
            dynamic product = 1;
            foreach (var item in input)
            {
                product *= item;
            }
            return product;
        }

        public static T Average<T>(this IEnumerable<T> input)
            where T : IComparable
        {
            dynamic sum = 0;
            dynamic count = 0;
            foreach (var item in input)
            {
                sum += item;
                count++;
            }
            return sum / count;
        }

        public static T Min<T>(this IEnumerable<T> input)
            where T : IComparable
        {
            dynamic min = long.MaxValue;
            foreach (var item in input)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> input)
            where T : IComparable
        {
            dynamic max = long.MinValue;
            foreach (var item in input)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

        static void Main()
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //decimal[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.5m };
            long[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       

            Console.WriteLine("Sum: {0}", Sum(numbers));
            Console.WriteLine("Product: {0}", Product(numbers));
            Console.WriteLine("Min: {0}", Min(numbers));
            Console.WriteLine("Max: {0}", Max(numbers));
            Console.WriteLine("Average: {0}", Average(numbers));
        }
    }
}
