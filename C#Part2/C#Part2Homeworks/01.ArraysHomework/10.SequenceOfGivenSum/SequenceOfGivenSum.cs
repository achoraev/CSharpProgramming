using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}	

class SequenceOfGivenSum
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };// ne raboti s 13
        int sum = 0;
        
        for (int i = 0; i < array.Length; i++)// check if given sum is bigger than sum of elements of array
        {
            sum += array[i];
        }
        Console.WriteLine("Enter Sum:");
        int number = int.Parse(Console.ReadLine());
        int tempSum = array[0];
        int endPosition = 0;        
        int startPosition = 0;

        if (number > sum)
        {
            Console.WriteLine("Number is bigger than sum of the elements of array {0}:", sum);
        }
        else
        {            
            //sum elements of array
            
            for (int j = 1; j < array.Length; j++)
            {
                tempSum += array[j];
                if (tempSum == number)
                {
                    endPosition = j;
                    break; 
                }
                else if (tempSum > number)
                {
                    tempSum = array[j];
                    startPosition = j;
                }
            }
                            
            //print sequence
            Console.Write("For Sum {0} sequence: ", number);
            Console.WriteLine();
            if (startPosition > endPosition)
            {
                Console.WriteLine("No sequence.");
            }
            for (int i = startPosition; i <= endPosition; i++)
            {
                Console.Write("{0}", array[i]);
                if (i != endPosition)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }        
    }
}