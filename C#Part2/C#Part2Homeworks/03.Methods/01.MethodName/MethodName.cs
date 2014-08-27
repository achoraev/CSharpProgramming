using System;
//Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.

class MethodName
{
	static void ReadName()
	{		
		Console.WriteLine("Enter your name: ");
        string yourName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", yourName); 	
	}
	
	static void Main()
	{
        ReadName();	 		
	}
}