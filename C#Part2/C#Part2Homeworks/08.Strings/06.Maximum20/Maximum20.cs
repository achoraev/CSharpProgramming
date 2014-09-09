using System;
// Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

class Maximum20
{
    static void Main()
    {        
		while (true)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
				break;
            }
            else
            {
                Console.WriteLine(input);                
                break;
            }
        }

    }
}
