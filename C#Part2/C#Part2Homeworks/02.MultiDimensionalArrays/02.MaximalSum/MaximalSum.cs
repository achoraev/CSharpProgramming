using System;
//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaximalSum
{
    static void Main()
    {
        int[,] rectangular = 
                {
                    {8,7,3,8},
                    {4,4,6,9},
                    {5,7,3,8},
                    {6,5,9,7},                                                      
                };
        int sum = 0;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        int rowMatrix = 3;
        int colMatrix = 3;

        //solution		
        for (int row = 0; row < rowMatrix; row++)
        {
            for (int col = 0; col < colMatrix; col++)
            {
                if (col + 1 == colMatrix || row + 1 == rowMatrix)
                {
                    break;
                }
                sum += rectangular[row, col] + rectangular[row, col + 1] + rectangular[row, col + 2] +
                       rectangular[row + 1, col] + rectangular[row + 1, col + 1] + rectangular[row + 1, col + 2] +
                       rectangular[row + 2, col] + rectangular[row + 2, col + 1] + rectangular[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
                sum = 0;
            }
        }
        PrintMatrix(rectangular, bestRow, bestCol);
    }

    static void PrintMatrix(int[,] rectangular, int bestRow, int bestCol)
    {
        for (int i = bestRow; i <= 3; i++)
        {
            for (int j = bestCol; j <= 3; j++)
            {
                Console.Write("{0,4}", rectangular[i, j]);
            }
            Console.WriteLine();
        }
    }
}