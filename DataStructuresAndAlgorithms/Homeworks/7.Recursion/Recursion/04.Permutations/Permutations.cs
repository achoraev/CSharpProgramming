// 4.Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. 
// Example:	n=3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
namespace Permutations
{
    using System;    
        
    public class Permutations
    {
        public static void Main()
        {
            // call that variant
            int n = 3;
            Permutate(0, n, new int[n], new bool[n]);

            // call second variant
            Console.WriteLine("Second variant with Generic");
            string str = "ABC";
            char[] charArry = str.ToCharArray();
            int[] intArray = new int[] { 1, 2, 3 };
            Permute.permute(charArry, 0);
            Console.WriteLine("with numbers");
            Permute.permute(intArray, 0);
            Console.ReadKey();
        }

        private static void Permutate(int p, int n, int[] arr, bool[] used)
        {
            if (p == n)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
                return;
            }

            for (int num = 0; num < n; num++)
            {
                if (used[num])
                {
                    continue;
                }

                arr[p] = num + 1;
                used[num] = true;
                Permutate(p + 1, n, arr, used);
                used[num] = false;
            }
        }
    }
}