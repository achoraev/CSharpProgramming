using System;

    class BatGoiko
    {
        static void Main()
		{
		int height = int.Parse (Console.ReadLine());	
		int towerHeight = (height * 2); 
		int delitel = 2;
        int crossbeam = 2;
        int step = 2;
		for (int row = 1; row <= height; row ++)
			{
                string betweenLine;
                string newLine =  new string('.', ((towerHeight - delitel) / 2));				
                if (row % crossbeam == 0)
                {
                    betweenLine = new string('-', ((towerHeight - (newLine.Length * 2)) - 2));
                    crossbeam += step;
                    step ++;          
                }
                else
                {
                    betweenLine = new string('.', ((towerHeight - (newLine.Length * 2)) - 2));                    
                }
                Console.WriteLine(newLine + "/" + betweenLine + "\\" + newLine);         				       
				delitel += 2;
			}			
		}
    }

