namespace Dividers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dividers
    {
        static int N;
        static bool[] used;
        static List<int> listOfNumbers = new List<int>();
        static List<int> combinations = new List<int>();
        static List<int> output = new List<int>();
        static SortedDictionary<int, int> dividers = new SortedDictionary<int, int>();
        public static void Main()
        {
            N = int.Parse(Console.ReadLine().Trim());
            if (N == 1)
            {
                Console.WriteLine(N);
            }
            else
            {
                used = new bool[N];
                for (int i = 0; i < N; i++)
                {
                    listOfNumbers.Add(int.Parse(Console.ReadLine().Trim()));
                }

                GenerateCombinations(0);

                CheckForDividers(output);
                FindAndPrintMinKey();                
            }
        }        

        private static void CheckForDividers(List<int> output)
        {
            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 1; j < output[i]; j++)
                {
                    if (output[i] % j == 0)
                    {
                        if (!dividers.ContainsKey(output[i]))
                        {
                            dividers.Add(output[i], 1);
                        }
                        else
                        {
                            dividers[output[i]]++;
                        }
                    }
                }
            }            
        }

        private static void FindAndPrintMinKey()
        {
            var minValue = dividers.Min(v => v.Value);
            var minKey = dividers.FirstOrDefault(v => v.Value == minValue).Key;
            Console.WriteLine(minKey);
        }

        private static void GenerateCombinations(int index)
        {
            if (index == N)
            {
                output.Add(int.Parse(string.Join("", combinations)));
                return;
            }
            else
            {
                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        combinations.Add(listOfNumbers[i]);
                        GenerateCombinations(index + 1);
                        used[i] = false;
                        combinations.Remove(listOfNumbers[i]);                        
                    }

                }
            }
        }
    }
}