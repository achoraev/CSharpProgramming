using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter string: ");
		string word = Console.ReadLine();
		List <char> reversed = new List<char>();
		for (int i = 0; i < word.Length; i++)
		{
            reversed.Add(word[i]);
        }
        reversed.Reverse();
        Console.Write("Reversed string is: ");
        for (int i = 0; i < reversed.Count; i++)
        {
            Console.Write(reversed[i]);
        }
        Console.WriteLine();
    }
}
