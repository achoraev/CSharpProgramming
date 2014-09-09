using System;
using NeighborsElements;
//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
//if there’s no such element.
//Use the method from the previous exercise.

namespace FindFirstBiggerNeighbor
{
    class FindFirstBiggerNeighbor
    {        
        
        public static void Main()
        {
            int[] arrayOfIntegers = { 4, 3, 2, 4, 2, 5, 4, 5, 4, 6, 5, 5, 6, 4, 8, 6, 4, 8, 6, 8};
            bool haveNumber = false;
            haveNumber = CheckElements(arrayOfIntegers, haveNumber);             
        }

        private static bool CheckElements(int[] arrayOfIntegers, bool haveNumber)
        {
            for (int i = 1; i < arrayOfIntegers.Length; i++)
            {
                if (NeighborsElements.NeighborsElements.CheckNeighbors(arrayOfIntegers, i))
                {
                    Console.WriteLine("First element is: {0} at position {1}.", arrayOfIntegers[i], i);
                    haveNumber = true;
                    break;
                }
            }
            if (!haveNumber)
            {
                Console.WriteLine("-1");
            }
            return haveNumber;
        }
    } 
}

