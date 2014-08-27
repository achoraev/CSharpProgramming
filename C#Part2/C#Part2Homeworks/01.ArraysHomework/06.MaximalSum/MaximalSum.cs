using System;
//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter arrays elements: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());
        int[] array = new int[numberN];
        int maxSum = 0;

        if (numberK > numberN)// check K > N 
        {
            Console.WriteLine("N must be bigger than K");
            return;
        }
        for (int i = 0; i < numberN; i++)   // read array
        {
            Console.WriteLine("Enter element[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array); //sort array

        Console.WriteLine("Sum the {0} elements from array of {1} elements:", numberK, numberN);

        for (int j = 0; j < numberK; j++)
        {
            Console.WriteLine("Element[{0}] = {1} ", array.Length -1 - j, array[array.Length - 1 - j]);
            maxSum += array[array.Length - 1 - j];
        }
        Console.WriteLine("Total Maximum Sum is: {0}", maxSum);
    }
}