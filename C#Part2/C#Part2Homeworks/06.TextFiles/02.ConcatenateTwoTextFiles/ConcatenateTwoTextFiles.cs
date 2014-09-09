using System;
using System.IO;
//Write a program that concatenates two text files into another text file.

class ConcatenateTwoTextFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\firstFile.txt");                
        string newFile = reader.ReadToEnd();        
        reader.Close();
        StreamReader secondReader = new StreamReader("..\\..\\secondFile.txt");
        newFile += secondReader.ReadToEnd();
        secondReader.Close();
        StreamWriter writer = new StreamWriter("test.txt");
        writer.WriteLine(newFile);
        writer.Close();        
    }
}

