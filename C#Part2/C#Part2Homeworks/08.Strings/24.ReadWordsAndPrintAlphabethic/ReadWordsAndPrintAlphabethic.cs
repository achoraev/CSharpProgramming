using System;
using System.Text.RegularExpressions;
using System.Linq;
// Write a program that reads a list of words, separated by spaces and prints the list 
//in an alphabetical order.

class ReadWordsAndPrintAlphabethic
{       		
	static void Main()
    {
		string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
		string [] list = text.Split(new char [] {' ', ',', '.', '?', '!', '(', ')'},StringSplitOptions.RemoveEmptyEntries);
		Array.Sort(list);
		foreach (var word in list) 
		{      
		Console.WriteLine(word);  
		}
	}	
}