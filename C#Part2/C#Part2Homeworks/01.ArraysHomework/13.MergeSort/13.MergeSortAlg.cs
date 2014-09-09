using System;
//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

class MergeSort
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 4, 5, 4, 6, 5, 5, 6, 4, 8, 6, 4, 8, 6, 8 };

        // Print the unsorted array   
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        //merge sort method
        MergeAlgorithm(array);
        
        // Print the sorted array   
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }

    private static int[] MergeAlgorithm(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }
        int middle = array.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }
        int[] right = new int[array.Length - middle];
        for (int i = 0; i < array.Length - middle; i++)
        {
            right[i] = array[i + middle];
        }
        if (left.Length >= 2) // ne raboti neshto tuk
        {
            left = MergeAlgorithm(left);// ne raboti neshto tuk
            right = MergeAlgorithm(right);// ne raboti neshto tuk
        }
        
        int leftptr = 0;
        int rightptr = 0;
        int[] sorted = new int[array.Length];
        for (int k = 0; k < array.Length; k++)
        {
            if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
            {
                sorted[k] = left[leftptr];
                leftptr++;
            }
            else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
            {
                sorted[k] = right[rightptr];
                rightptr++;
            }
        }
        
        return sorted;
    }
}

