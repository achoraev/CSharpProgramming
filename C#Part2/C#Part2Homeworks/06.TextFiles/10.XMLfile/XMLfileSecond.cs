using System;
using System.IO;
using System.Text;
using System.Xml;
// Write a program that extracts from given XML file all the text without the tags. 
//Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age>
//<interests count="3"><interest> Games</instrest><interest>C#</instrest>
//<interest> Java</instrest></interests></student>

class XMLfile
{
static void Main()
	{
		XmlDocument doc = new XmlDocument();// check and other version with RegEx
		doc.Load(@"../../file.xml");
		XmlElement docElement = doc.DocumentElement;
		StreamWriter writer = new StreamWriter(@"../../text.txt");
		using (writer)
		{
			foreach (XmlNode childNode in docElement.ChildNodes)
			{
				writer.WriteLine(childNode.InnerText);// check folder for output file
			}  
		} 
	}
}

