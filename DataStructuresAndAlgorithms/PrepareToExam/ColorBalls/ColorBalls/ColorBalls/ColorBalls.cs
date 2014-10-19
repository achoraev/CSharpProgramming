namespace ColorBalls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ColorBalls
    {
        static int n;
        static int k;
        static int result = 0;
        static string input;        
        static HashSet<char> numberOfColors = new HashSet<char>();
        static int[] arr;

        static void Main()
        {
            input = Console.ReadLine();
            var sorted = input.ToCharArray().OrderBy(x => x);
            input = string.Join("", sorted);

            for (int i = 0; i < input.Length; i++)
            {
                numberOfColors.Add(input[i]);
            }

            n = input.Length;
            k = numberOfColors.Count();
            arr = new int[n];

            PermuteRep(input.ToArray(), 0, n);
            
            Console.WriteLine(result);
        }

        static void PermuteRep(char[] arr, int start, int n)
        {
            result++;

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = firstElement;
            }
        }        

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}