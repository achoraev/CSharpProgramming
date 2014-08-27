using System;

class Trapezoid
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int width = num * 2;
        int heigth = num + 1;
        int[,] matrix = new int[heigth, width];
        //Solution
        int currentRow = 0;
        int currentCol = num;
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
            if (currentCol >= width)
            {
                currentCol--;
                matrix[currentRow, currentCol] = 1;
                currentRow++;
            }
            if (currentRow >= heigth)
            {
                break;                
            }            
        }
        currentCol--;
        currentRow--;
        while (true)
        {
            if (currentRow == num)
            {
                matrix[currentRow, currentCol] = 1;
                currentCol--;
            }
            if (currentCol < 0 | currentRow < num)
            {
                currentCol++;
                matrix[currentRow, currentCol] = 1;
                
                currentRow--;
            }
            if (currentRow < 1)
            {
                break;
            }
        }

        //Print
        for (int row = 0; row < heigth; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}