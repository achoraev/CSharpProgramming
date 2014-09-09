using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//(examples for n = 4)

class Spirala
{
	static void Main()
	{
		Console.WriteLine("Enter size of matrix: "); 
		int n = int.Parse(Console.ReadLine());
		int[,] matrix = new int[n, n];		
		int row = 0;
		int col = 0;
        string direction = "down"; 
		int maxRotations = n * n;
		
		for (int counter = 1; counter <= maxRotations; counter++)
        {
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "right";
                row--;
                col++;
            }
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "up";
                col--;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "left";
                row++;
                col--;
            }

            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "down";
                col++;
                row++;
            }

            matrix[row, col] = counter;

            
            if (direction == "down")
            {
                row++;
            }
            if (direction == "right")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
            if (direction == "left")
            {
                col--;
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