namespace ZigZagCount
{
    using System;

    public class ZigZagCount
    {        
        static int n;        
        static int k;
        static int result;        
        static int index = 0;        
        static bool[] used;
        static int[] numbers;

        public static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            n = int.Parse(input[0]);
            k = int.Parse(input[1]);  
            numbers = new int[k];
            used = new bool[n];

            // print
            if (input[1] != "1")
            {
                GenerateCombinations(index);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(input[0]);
            }
        }

        private static void GenerateCombinations(int index)
        {
            if (index == k)
            {
                result++;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (used[i])
                {
                    continue;
                }

                if (index % 2 == 0)
                {
                    if (index == 0 || i > numbers[index - 1])
                    {                        
                        numbers[index] = i;
                        used[i] = true;
                        GenerateCombinations(index + 1);
                        used[i] = false;
                    }
                }
                else
                {
                    if (index == 0 || i < numbers[index - 1])
                    {                       
                        numbers[index] = i;
                        used[i] = true;
                        GenerateCombinations(index + 1);
                        used[i] = false;
                    }
                }
            }
        }
    }
}