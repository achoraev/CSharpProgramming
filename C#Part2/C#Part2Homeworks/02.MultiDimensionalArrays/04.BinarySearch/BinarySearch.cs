using System;
//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K. 

class BinarySearch
{
	static void Main()
	{
		Console.WriteLine("Enter size of array: "); 
		int numberN = int.Parse(Console.ReadLine());
		int[] array = new int [numberN];
		for (int i = 0; i < numberN; i++)
		{
			Console.WriteLine("Enter element of array: "); 
			array[i] = int.Parse(Console.ReadLine());	
		}
		Console.WriteLine("Enter integer K: "); 
		int numberK = int.Parse(Console.ReadLine());
		
		Array.Sort(array);
        int foundK = Array.BinarySearch(array, numberK);
        if (foundK < 0)
        {
            foundK = Array.BinarySearch(array, numberK - 1);
            if (foundK<=0)
            {
                Console.WriteLine("Number not found.");
            }
            else
            {            
            Console.WriteLine("Found number is: {0} at position {1}", array[foundK], foundK); 
            }
        }
        else if (array[foundK] == numberK)
		{            
            Console.WriteLine("Found number is: {0} at position {1}", array[foundK], foundK);
		}
		else
		{            
            Console.WriteLine("Found number is: {0} at position {1}", array[foundK], foundK);
		}
	}
}