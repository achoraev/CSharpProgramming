using System;
using System.Collections.Generic;
using System.Text;

class Pattern
{
    static void Main()
    {
        // input
        int rowsAndCols = int.Parse(Console.ReadLine().TrimEnd());
        long[,] field = new long[rowsAndCols, rowsAndCols];
        for (int row = 0; row < rowsAndCols; row++)
        {
            string[] inputNumbers = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string inputNumbers = Console.ReadLine().Split();
            for (int col = 0; col < rowsAndCols; col++)
            {
                field[row, col] = long.Parse(inputNumbers[col]);
            }
        }
        // solution
        long sum = 0;
        long result = 0;
        long diagonal = 0;
        bool havePatern = false;
        for (int row = 0; row < field.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < field.GetLength(1) - 4; col++)
            {
                if (field[row, col] != field[row, col + 1] - 1)
                {
                    continue;
                }                
                else if (   field[row, col] == field[row, col + 1] - 1
                    && field[row, col + 1] == field[row, col + 2] - 1
                    && field[row, col + 2] == field[row + 1, col + 2] - 1
                    && field[row+1, col + 2] == field[row + 2, col + 2] - 1
                    && field[row + 2, col + 2] == field[row + 2, col+3] - 1
                    && field[row + 2, col + 3] == field[row + 2, col+4] - 1)
                {
                    sum = SumNumbers(field, row, col);
                    if (sum > result)
                    {
                        result = sum;
                    }
                    havePatern = true;
                }
                else
                {
                    diagonal = SumMainDiagonal(field);
                    continue;
                }
            }
        }

        //result
        
        if (havePatern)
        {
            Console.Write("YES" + " " + result);
            //Console.Write(" ");
            Console.WriteLine(); 
        }
        else
        {
            Console.Write("NO");
            Console.Write(" ");
            Console.WriteLine(diagonal);    
        }
    }

    static long SumMainDiagonal(long [,] field)
    {
        long sum = 0;
        int col = 0;
        for (int row = 0; row < field.GetLength(0); row++)
        {
            sum += field[row, col];
            col++;
        }
        return sum;
    }

    static long SumNumbers(long [,] field, int row, int col)
    {
        long sum = 0;
        //horizontal pattern
        for (int i = col; i <= col + 2; i++)
        {
            sum += field[row, i];
        }
        //vertical pattern
        for (int j = row+1; j <= row+2; j++)
        {
            sum += field[j, col + 2];
        }
        //horizontal pattern bottom
        for (int i = col+3; i <= col+4; i++)
        {
            sum += field[row+2, i];
        }        
        return sum;
    }
}
