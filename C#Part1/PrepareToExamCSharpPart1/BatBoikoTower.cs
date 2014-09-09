using System;

	class BatBoikoTower
	{
		static void Main()
		{
		int height = int.Parse (Console.Readline());	
		int towerHeight = (height * 2); 
		int delitel = 2;
		
		for (int row = 1; row <= height; row ++)
			{
				string newLine = new.String ('.', ((towerHeight - delitel) / 2));
				string betweenLine = new.String ('-', ((towerHeight - (newLine.Lenght*2))-2));				
				
				Console.Writeline (newLine + "/" + betweenLine + "\\"+ newLine);
				delitel += 2;
			}			
		}
	}