using System;
using System.IO;
// Describe the strings in C#. What is typical for the string data type? 
// Describe the most important methods of the String class.

class DescribeStrings
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../Describe.txt"))
		{
		string result = reader.ReadToEnd();
		Console.WriteLine(result);
		}
    }
}
