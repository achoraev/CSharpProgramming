using System;
using System.Text;
using System.Text.RegularExpressions;
// You are given a text. 
//Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to uppercase. The tags cannot be nested. 
//Example:
//We are living in a <upcase>yellow submarine</upcase>. 
//We don't have <upcase>anything</upcase> else.
//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class ChangeToUppercase
{
    static void Main()
    {        
		string text = 
		"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
		string result = Regex.Replace(text, @"<upcase>([\w\s]*)</upcase>", match => match.Groups[1].Value.ToUpper());		
		Console.WriteLine(result);		
    }
}
