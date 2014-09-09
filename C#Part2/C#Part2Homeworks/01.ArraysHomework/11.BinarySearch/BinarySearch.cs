using System;
//Write a program that finds the index of given element in a sorted array of integers
// by using the binary search algorithm (find it in Wikipedia).

class BinarySearch
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 4, 5, 4, 6, 5, 5, 6, 4, 8, 6, 4, 8, 6, 8 };
        object myObject = 9;
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
        int myIndex = Array.BinarySearch(array, myObject);
        if (myIndex < 0)
        {
            Console.WriteLine
            ("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
        }
        else
        {
            Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
        }
    }
}