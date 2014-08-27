using System;
//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class IsLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        if (year < 1 || year > 9999)
        {
            Console.WriteLine("Wrong year!!!");
        }
        else
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Year is leap! ");
            }
            else
            {
                Console.WriteLine("Year is not leap! ");
            }
        }
    }
}

