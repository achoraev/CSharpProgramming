using System;
using System.Text;
// Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class CheckBrackets
{
    static void Main()
    {        
		string expression = "((a+b)/5-d)";//correct
        //string expression = ")(a+b))";//incorrect
		int countbrackets = 0;
		
		for (int i = 0; i < expression.Length; i++)
		{
			if (expression[i] == '(')
			{
				countbrackets++;
			}
			else if (expression[i] == ')')
			{
				countbrackets--;				
			}
			else 
			{	
				continue;
			}			
		}
		if (countbrackets == 0)
		{
		Console.WriteLine("Brackets are correct!!!");
		}
		else 
		{
		Console.WriteLine("Incorrect brackets!!!");
		}
    }
}
