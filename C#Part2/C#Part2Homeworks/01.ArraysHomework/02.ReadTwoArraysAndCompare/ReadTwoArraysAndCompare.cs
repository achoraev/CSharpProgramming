using System;
//Write a program that reads two arrays from the console and compares them element by element.

class ReadTwoArraysAndCompare
{
    static void Main()
    {
        int[] arrayOne = new int[5];
        int[] arrayTwo = new int[5];
        for (int i = 0; i < arrayOne.Length; i++)// read array 
        {
            Console.WriteLine("Enter number: ");
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < arrayTwo.Length; j++) // read array
        {
            Console.WriteLine("Enter number: ");
            arrayTwo[j] = int.Parse(Console.ReadLine());
        }

        for (int k = 0; k < 5; k++)
        {
            if (arrayOne[k] > arrayTwo[k])
            {
                Console.WriteLine("First number {0} is bigger that second number {1} ", arrayOne[k], arrayTwo[k]);
            }
            else if (arrayOne[k] < arrayTwo[k])
            {
                Console.WriteLine("First number {0} is smaller that second number {1} ", arrayOne[k], arrayTwo[k]);
            }
            else
            {
                Console.WriteLine("First number {0} is equal to second number {1} ", arrayOne[k], arrayTwo[k]);
            }
        }
    }
}

