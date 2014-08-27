using System;
//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

class MaxSumSeq
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int maxSum = array[0];
        int endPosition = 0;
        int startPosition = 0;
        int tempSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            tempSum += array[i];
            if (tempSum > maxSum)
            {
                maxSum = tempSum;
                endPosition = i+1;
            }
            if (tempSum < 0)
            {
                tempSum = 0;
                startPosition = i+1;
            }
        }
        
        //print sequence
        for (int i = startPosition; i < endPosition; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Sum = {0}", maxSum);

    }
}