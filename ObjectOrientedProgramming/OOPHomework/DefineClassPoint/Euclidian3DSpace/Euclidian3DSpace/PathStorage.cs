using System;
using System.Collections.Generic;
using System.IO;

namespace Euclidian3DSpace
{
	public static class PathStorage
	{			
		public static void SaveToFile(Path path) 
		{
			using (StreamWriter writer = new StreamWriter("../../Test.txt"))
			{
				foreach (var point in path.Points)
				{
					writer.WriteLine(point);
				}
				Console.WriteLine("The path is save successfuly!");
			}		
		}
		
		public static Path LoadFromFile() 
		{
			Path loadFile = new Path();
			using (StreamReader reader = new StreamReader("../../Test.txt"))
			{
				while(reader.Peek() >= 0)
				{
					string line = reader.ReadLine();
					string [] splitLine = line.Split(new char [] {'(', ')', ',', ' '},StringSplitOptions.RemoveEmptyEntries);
                    loadFile.AddPoint(new Point3D(int.Parse(splitLine[0]), int.Parse(splitLine[1]), int.Parse(splitLine[2])));
				}
                Console.WriteLine("The path is loaded succesfully!!!");
			}
			return loadFile;
		}		
	}
}	