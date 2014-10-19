namespace ColorBalllsCombinations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ColorBalllsPermutations
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

            GenerateCombinationsNoRepetitions(0,0);            
            Console.WriteLine(result);
        }

        public static void GenerateCombinationsNoRepetitions(int index, int start)
        {
            if (index >= k)
            {
                result++;
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i);
                }
            }
        }        
    }
}