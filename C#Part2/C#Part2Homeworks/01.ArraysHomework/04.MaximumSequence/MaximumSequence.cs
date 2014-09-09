using System;
//04. Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class MaximumSequence
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int maxSequence = 0;
        int currentSequence = 0;
        int SequenceNumber = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentSequence++;
            }
            else
            {
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    SequenceNumber = numbers[i];
                }
                currentSequence = 1;
            }
        }
        // Special case
        if (currentSequence > maxSequence)
        {
            maxSequence = currentSequence;
            SequenceNumber = numbers[numbers.Length - 1];
        }

        // Print the maximum sequence
        
        Console.WriteLine("The maximum sequence is: ");
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write("{0} ", SequenceNumber);
        }
    }
}