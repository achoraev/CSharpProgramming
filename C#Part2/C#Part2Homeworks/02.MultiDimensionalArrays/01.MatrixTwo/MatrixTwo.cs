using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//(examples for n = 4)

class MatrixTwo
{
    static void Main()
    {
        Console.WriteLine("Enter size of matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else if (col % 2 != 0)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    matrix[i, col] = counter;
                    counter++;
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