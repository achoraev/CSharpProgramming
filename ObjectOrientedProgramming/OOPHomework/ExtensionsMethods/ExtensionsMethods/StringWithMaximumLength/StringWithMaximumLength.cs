namespace StringWithMaximumLength
{
    using System;    
    using System.Linq;    
    // 17. Write a program to return the string with maximum length from an array of strings. Use LINQ.

    public class StringWithMaximumLength
    {
        static void Main()
        {
            string[] listOfStrings = new string[]
            {
                "program start", 
                "max",
                "returnthestringwithmaximum",
                "array of strings",
                "length",
                "*"
            };
            Console.WriteLine("String with maximum length is: ");
            Console.WriteLine(listOfStrings.OrderByDescending(st => st.Length).First());
        }
    }
}
