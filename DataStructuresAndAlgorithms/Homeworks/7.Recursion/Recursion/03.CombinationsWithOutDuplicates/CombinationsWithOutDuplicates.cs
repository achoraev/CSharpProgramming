// 3.Modify the previous program to skip duplicates:
// n=4, k=2  (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
namespace CombinationsWithDuplicates
{
    using System;

    public class CombinationsWithDuplicates
    {
        static int[] numbers;
        static int countOfElements;
        static int index = 0;
        static int combinations;

        public static void Main()
        {
            Console.WriteLine("Enter N: ");
            countOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            combinations = int.Parse(Console.ReadLine());
            numbers = new int[combinations];

            GenerateCombinations(index);
        }

        private static void GenerateCombinations(int index)
        {
            if (index == combinations)
            {
                Console.WriteLine("({0})", string.Join(", ", numbers));
                return;
            }

            for (int i = 1; i <= countOfElements; i++)
            {
                numbers[index] = i;
                if (index == 0 || numbers[index] > numbers[index - 1])
                {
                    GenerateCombinations(index + 1);
                }
            }
        }
    }
}