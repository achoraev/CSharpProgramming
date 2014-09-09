using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

class QuickSort
{
	static void Main()
	{
        string[] array = { "z", "e", "x", "c", "m", "q", "a" };
				        
		// Print the unsorted array   
        for (int i = 0; i < array.Length; i++)  
		{       
		Console.Write(array[i] + " ");  
		}         
		Console.WriteLine();      
		// Sort the array     
        Quicksort(array, 0, array.Length - 1); 
		// Print the sorted array   
			for (int i = 0; i < array.Length; i++)  
			{      
			Console.Write(array[i] + " "); 
			}     
		Console.WriteLine(); 
		Console.ReadLine();   
	}  
	
	public static void Quicksort(IComparable[] elements, int left, int right) 
	{        
		int i = left, j = right;   
		IComparable pivot = elements[(left + right) / 2];    
		while (i <= j)   
		{        
			while (elements[i].CompareTo(pivot) < 0)   
			{     
			i++;    
			}     
			while (elements[j].CompareTo(pivot) > 0)    
			{       
			j--;    
			}     
			if (i <= j)   
			{       
			// Swap    
			IComparable tmp = elements[i];  
			elements[i] = elements[j];   
			elements[j] = tmp;   
			i++;     
			j--;       
			}      
		}       
		// Recursive calls    
		if (left < j)  
		{      
		Quicksort(elements, left, j);   
		}     
			if (i < right)    
			{           
			Quicksort(elements, i, right);  
			} 
	}
}


