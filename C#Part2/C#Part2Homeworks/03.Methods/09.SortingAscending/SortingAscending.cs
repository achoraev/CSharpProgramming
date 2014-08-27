using System;
//Write a method that return the maximal element in a portion of array of integers 
//starting at given index. Using it write another method that sorts an array in 
//ascending / descending order.

class SortingAscending
{
	static int GetMax (int [] array, int position)
	{
		int max = int.MinValue;
		for (int i = position; i < array.Length; i ++)
		{
			if (array[i] > max)
			{
				max = array[i];
			}            
		}
		return max;
	}
	
	static int[] SortingDescending (int [] array)
	{        
        int maximumValue = 0;
		//sorting alg 
        for (int i = 0; i < array.Length; i++)
        {           
           maximumValue = GetMax(array, i);// use GetMax           
           
           if (maximumValue != array[i])
           {
               int temporaryVariable = array[Array.IndexOf(array, maximumValue)];
               array[Array.IndexOf(array, maximumValue)] = array[i];
               array[i] = temporaryVariable;
           }
        }		
        return array;	
	}
	static void Main()
	{        
        int[] array = { 1, 15, 22, 5, 5, 8, 9, 55, 11, 99, 100, -5, 99999, -8 };
		int position = 0;
		int max = GetMax (array, position);		
		Console.WriteLine("Maximal number is: {0}", max);
        int[] finalArrae = SortingDescending(array);
        Console.WriteLine("Descending sorted: ");
        for (int i = 0; i < finalArrae.Length; i++)
        {           
            Console.Write("{0} ", finalArrae[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Ascending sorted: ");
        for (int i = finalArrae.Length-1; i >= 0; i--)
        {
            Console.Write("{0} ", finalArrae[i]);
        }
        Console.WriteLine();
        Console.ReadLine();
	}
}