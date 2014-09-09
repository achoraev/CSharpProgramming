using System;
//Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).

namespace NeighborsElements
{
    public class NeighborsElements
    {
        public static bool CheckNeighbors(int[] array, int position)
        {
            if (position < 1 || position > array.Length - 1)
            {
                Console.WriteLine("At that position no two neighbors!!!");
                return false;
            }
            else if (array[position] > array[position - 1] && array[position] > array[position + 1] && position > 0 && position < array.Length - 1)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            int[] arrayOfIntegers = { 4, 3, 1, 4, 2, 5, 4, 5, 4, 6, 5, 5, 6, 4, 8, 6, 4, 8, 6, 8 };
            Console.WriteLine("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            bool isTrue = CheckNeighbors(arrayOfIntegers, position);
            if (isTrue)
            {
                Console.WriteLine("Element in position: {0} is {1} and is bigger than neighbors.", position, arrayOfIntegers[position]);
            }
            else
            {
                Console.WriteLine("Element in position: {0} not bigger than neighbors.", position);
            }
        }
    }
}

