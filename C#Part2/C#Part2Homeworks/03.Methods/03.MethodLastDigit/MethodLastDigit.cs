using System;
//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".

class MethodLastDigit
{
	static string ReturnLastDigit (int number)
	{
		string lastWord = "";
		int lastDigit = number % 10;
		switch (lastDigit)
		{
			case 0: lastWord = "zero"; break; 
			case 1: lastWord = "one"; break;   
			case 2: lastWord = "two"; break;   
			case 3: lastWord = "three"; break;    
			case 4: lastWord = "four"; break;  
			case 5: lastWord = "five"; break;   
			case 6: lastWord = "six"; break;    
			case 7: lastWord = "seven"; break;    
			case 8: lastWord = "eight"; break;    
			case 9: lastWord = "nine"; break;		
		}
		
		return lastWord;
	}
	
	static void Main()
	{
		Console.WriteLine("Enter number: "); 
		int integerNumber = int.Parse(Console.ReadLine());
		string lastWord = ReturnLastDigit(integerNumber);
		
		Console.WriteLine("Last number is: {0} ", lastWord); 		
	}
}