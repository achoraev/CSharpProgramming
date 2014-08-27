using System;
using System.Collections.Generic;

class TheyAreGreen
{
  static void Main()
  {
	// input
	int numberOfChars = int.Parse(Console.ReadLine());
	char [] chars = new char [numberOfChars];
	int result = 1;
	for (int i = 0; i < chars.Length;i++)
	{
		chars[i] = char.Parse(Console.ReadLine());
	}	
   //solution
   
    for (int i = numberOfChars; i > 1; i-=2)// if unique letters permutations are n!
            {
                result *= i * (i - 1);
            }         
   
   //print
   Console.WriteLine(result);
  }
}
