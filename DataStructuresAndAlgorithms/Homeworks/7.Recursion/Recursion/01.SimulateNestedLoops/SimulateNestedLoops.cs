// 1.Write a recursive program that simulates the execution of n nested loops from 1 to n. 
namespace SimulateNestedLoops
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SimulateNestedLoops
    {
        static int count = 0;
        static int numberOfLoops;
        static int[] numbers;
        static Stack<int> stackNumbers = new Stack<int>();
        public static void Main()
        {
            Console.WriteLine("Enter number of loops: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            numbers = new int[numberOfLoops];
            Console.WriteLine("Solution with array.");
            GenerateCombinations(count);
            Console.WriteLine();
            Console.WriteLine("Solution with stack.");
            GenerateCombinationsWithStack();
            Console.ReadLine();             
        }

        private static void GenerateCombinationsWithStack()
        {
            if (stackNumbers.Count == numberOfLoops)
            {
                Console.WriteLine(string.Join(", ", stackNumbers.Reverse()));
                return;
            }

            for (int i = 1; i <= numberOfLoops; i++)
            {
                stackNumbers.Push(i);
                GenerateCombinationsWithStack();
                stackNumbers.Pop();
            }
        }

        private static void GenerateCombinations(int count)
        {
            if (count == numberOfLoops)
            {
                Console.WriteLine(string.Join(", ", numbers));
                return;
            }

            for (int i = 1; i <= numberOfLoops; i++)
            {
                numbers[count] = i;
                GenerateCombinations(count + 1);
            }
        }
    }
}