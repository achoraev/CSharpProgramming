using System;
using System.IO;
//Write a program that compares two text files line by line and prints the number of lines that are the same 
//and the number of lines that are different. Assume the files have equal number of lines.

class ComparesTwoTextFiles
{
    static void Main()
    {        
        StreamReader reader = new StreamReader("..\\..\\first.txt");
        StreamReader secondReader = new StreamReader("..\\..\\second.txt");        
        string line = reader.ReadLine();
        string lineSecond = secondReader.ReadLine();
        int numberOfSameLines = 0;
        int numberOfDiffLines = 0;
        while (line != null)
        {            
            if (line.CompareTo(lineSecond) == 0)
            {
                numberOfSameLines++;
            }
            else
            {
                numberOfDiffLines++;
            }
            line = reader.ReadLine();
            lineSecond = secondReader.ReadLine();           
        }
        reader.Close();
        secondReader.Close();
        Console.WriteLine("Number of same lines: {0}", numberOfSameLines);
        Console.WriteLine("Number of different lines: {0}", numberOfDiffLines);              
    }
}

