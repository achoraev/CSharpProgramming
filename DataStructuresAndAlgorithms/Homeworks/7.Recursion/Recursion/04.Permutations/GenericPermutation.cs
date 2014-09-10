// 4.Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. 
// Example:	n=3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
namespace Permutations
{
    using System;

    public static class Permute
    {        
        public static void permute<T>(T[] arry, int k)
        {
            int j;
            if (k >= arry.Length)
                Console.WriteLine(string.Join(", ", arry));
            else
            {
                permute(arry, k + 1);
                for (int i = k + 1; i < arry.Length; i++)
                {
                    swap(ref arry[k], ref arry[i]);
                    permute(arry, k + 1);
                    swap(ref arry[k], ref arry[i]); //backtrack
                }
            }
        }
        private static void swap<T>(ref T a, ref T b)
        {
            T tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}