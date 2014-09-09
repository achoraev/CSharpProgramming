using System;
using System.IO;
using System.Collections.Generic;
// Write a program that deletes from given text file all odd lines. 
//The result should be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        WriteLines(ReadEvenLines()); 
    }
	
	static List<string> ReadEvenLines()
    {
        List<string> lines = new List<string>();
        int n = 1;

        using (StreamReader reader = new StreamReader("../../text.txt"))
		{
            for (string line; (line = reader.ReadLine()) != null; n++)
			{
                if (n % 2 == 0) 
				{
				lines.Add(line);
				}
			}
		}
        return lines;
    }

    static void WriteLines(List<string> lines)
    {
        using (StreamWriter writer = new StreamWriter("../../text.txt"))
		{
            foreach (string line in lines)
			{
                writer.WriteLine(line);
			}
		}
    }
}

