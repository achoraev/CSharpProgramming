using System;
using System.IO;
//Write a program that reads a text file and prints on the console its odd lines.

class ReadAndPrintOddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("D:\\My Docs\\VSProjects\\C#Part2Homework\\06.TextFiles\\text.txt"))
        {           
            //string file = reader.ReadToEnd(); // read all file
            for (int i = 1; i < 15; i ++)
            {
                string line = reader.ReadLine();
                if (i % 2 != 0)
                {
                    Console.WriteLine(line); 
                }
            }   
        }
    }
}

