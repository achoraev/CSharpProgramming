using System;
using System.Text;
using System.Text.RegularExpressions;
// Write a program that finds how many times a substring is contained in a given text 
//(perform case insensitive search).
//Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day.
//We will move out of it in 5 days.

//The result is: 9.

class FindSubstring
{
    static void Main()
    {        
		string text = 
		"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";        
        Console.WriteLine("The result is: {0}", Regex.Matches(text, "in", RegexOptions.IgnoreCase).Count); // with regex in one row :)
        // second edition
        string lowerText = text.ToLower();
        int result = 0;
        int found = 0;
        for (int i = 0; i < text.Length; i++)
        {
            found = lowerText.IndexOf("in", found + 1);
            if (found >= 0)
            {
                result++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The result is: {0}.", result);
    }
}
