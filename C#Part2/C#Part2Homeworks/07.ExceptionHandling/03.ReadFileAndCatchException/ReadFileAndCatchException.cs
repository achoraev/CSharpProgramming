using System;
using System.IO;
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadFileAndCatchException
{
    static void Main()
    {
        string path = @"D:\My Docs\VSProjects\C#Part2Homework\07.ExceptionHandling\01.CalculateAndPrintSqrt\text.txt";
        try
        {
            string allFile = File.ReadAllText(path);
            Console.WriteLine(allFile);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!!!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File is empty!!!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!!!");
        }
        catch (Exception)
        {
            Console.WriteLine("Can't read file!!!");
        }
    }
}

