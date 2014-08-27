using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//(examples for n = 4)

class MatrixThree
{
    static void Main()
    {
        Console.WriteLine("Enter size of matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int row = n-1;
        int col = 0;

        for (int i = 1; i <= n * n; i++)
        {
            matrix[row, col] = counter;
            row++;
            col++;
            counter++;
            if (row == n || col == n)
            {
                row--;
                if (col == n)
                {
                    row--;
                    col--;
                }
                while (row - 1 >= 0 && col - 1 >= 0)
                {
                    row--;
                    col--;
                }
            }
        }

        // print matrix
        PrintMatrix(n, matrix);
    }

    private static void PrintMatrix(int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}