using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
// Write a program that extracts from given XML file all the text without the tags. 
//Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age>
//<interests count="3"><interest>Games</instrest><interest>C#</instrest>
//<interest> Java</instrest></interests></student>

class XMLfile
{
static void Main()
	{
        using (StreamReader inputFile = new StreamReader("../../file.xml"))
		{
            using (StreamWriter outputFile = new StreamWriter("../../Output.txt"))
			{
			  string fileContent = inputFile.ReadToEnd();
			  string content = Regex.Replace(fileContent, "<(.*?)>", " ");
			  outputFile.WriteLine(content);
			}
		}
	}
}

