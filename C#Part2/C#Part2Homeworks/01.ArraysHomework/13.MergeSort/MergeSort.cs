using System;
//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

class MergeSort
{
	static void Main()
	{
        int[] arrayOfIntegers = { 4, 3, 1, 4, 2, 5, 4, 5, 4, 6, 5, 5, 6, 4, 8, 6, 4, 8, 6, 8 };
        int[] sortedArray = MergeSortAlgorithm(arrayOfIntegers);
        //print unsorted
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            Console.Write(arrayOfIntegers[i] + " ");
        }
        Console.WriteLine();      
        PrintArray(sortedArray);
	} 

	//merges two arrays
    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }

        return result;
    }

    //recursevily merges two arrays
    static int[] MergeSortAlgorithm(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = MergeSortAlgorithm(leftArray);
        rightArray = MergeSortAlgorithm(rightArray);

        return MergeArrays(leftArray, rightArray);
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}

