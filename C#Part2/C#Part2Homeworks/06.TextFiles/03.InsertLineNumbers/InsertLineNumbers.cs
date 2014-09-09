using System;
using System.IO;
//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

class InsertLineNumbers
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("test.txt");
        StreamReader reader = new StreamReader("..\\..\\text.txt");        
        int lineNumber = 0;
        string line = reader.ReadLine();
        while (line != null)
        {
            lineNumber++;
            writer.WriteLine("Line {0}: {1}", lineNumber, line);
            line = reader.ReadLine();
                
        }
        reader.Close();
        writer.Close();
    }
}

