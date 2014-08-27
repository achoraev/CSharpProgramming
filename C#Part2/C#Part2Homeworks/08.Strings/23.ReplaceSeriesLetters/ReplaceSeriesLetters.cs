using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
// Write a program that reads a string from the console and replaces all series of 
//consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

class ReplaceSeriesLetters
{       		
	static void Main()
    {
		Console.WriteLine("Enter identical letters:(example: aaaaabbbbbcdddeeeedssaa)");
		string inputText = "aaaaabbbbbcdddeeeedssaa";
        //string inputText = Console.ReadLine();
		Console.WriteLine(Encode(inputText));
		// second solution
        //char prevChar = Char.MinValue;
        //StringBuilder builder = new StringBuilder();
        //for (int i = 0; i < inputText.Length; i++)
        //{
        //    if (inputText[i] != prevChar)
        //    {
        //        builder.Append(inputText[i]);
        //        prevChar = inputText[i];
        //    }
        //}
        //Console.WriteLine(builder);
	}
	
	public static string Encode(string toEncode)// !!! check
	{
		StringBuilder sb = new StringBuilder(); 
		//int count = 1; 
		char current = toEncode[0]; 
		for (int i = 1; i < toEncode.Length; i++)
		{
			if (current == toEncode[i])
			{
				continue;
				//count++;
			} 
			else
			{
				sb.Append(current);
				//count = 1;
				current = toEncode[i];
			}
		}
		sb.Append(current);
		return sb.ToString();
	}
}