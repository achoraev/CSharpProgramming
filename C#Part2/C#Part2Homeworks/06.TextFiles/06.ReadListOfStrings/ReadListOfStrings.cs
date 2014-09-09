using System;
using System.IO;
//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file. Example:
/*	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter*/

class ReadListOfStrings
{
    static void Main()
    {
        string path = @"...\...\listOfStrings.txt";
        StreamReader reader = new StreamReader(path);

        string[] listOfStrings = new string[4];

        for (int i = 0; i < listOfStrings.Length; i++)
        {
            listOfStrings[i] = reader.ReadLine();
        }        
        reader.Close();
        Array.Sort(listOfStrings);
        StreamWriter writer = new StreamWriter("result.txt");
        for (int i = 0; i < listOfStrings.Length; i++)
        {
            writer.WriteLine(listOfStrings[i]);
        }
        writer.Close(); // chech folder: .....\bin\Debug for result
    }
}