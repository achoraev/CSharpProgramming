using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//(examples for n = 4)

class Matrix
{
	static void Main()
	{
		Console.WriteLine("Enter size of matrix: "); 
		int n = int.Parse(Console.ReadLine());
		int[,] matrix = new int[n, n];
		int counter = 1;
		int row = 0;
		int col = 0;
									
		while (true)
		{
			matrix[row, col] = counter; 
			counter++;
			row++;
			if(row == n)
			{
			row = 0;
			col++;
			}
		
			if(counter == (n*n)+1)
			{
			break;
			}		
		}
		// print matrix
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0,4}", matrix[i,j]); 
			}
			Console.WriteLine(); 
		}
	}
}