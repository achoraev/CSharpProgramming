using System;
using System.Collections.Generic;
using System.Text;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

class ReadDates
{
    static void Main()
    {
        string firstDate = "27.02.2006";
        string secondDate = "3.03.2006";        
        DateTime first;
        DateTime second;
        DateTime.TryParse(firstDate, out first);
        DateTime.TryParse(secondDate, out second);
        
        if (first == DateTime.MinValue || second == DateTime.MinValue)
        {
            Console.WriteLine("Please Enter Valid Date: ");            
        }
        else
        {
            TimeSpan result = second - first;
            Console.WriteLine("{0} days.",result.Days);
        }
    }
}

