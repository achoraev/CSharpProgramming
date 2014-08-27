namespace MoveInMatrix
{
    using System;

    public class MoveInMatrix
    {
        private static int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
        private static int countNumber = directionX.Length;

        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            int numberOfRows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numberOfRows, numberOfRows];
            int number = 1,
                row = 0,
                col = 0,
                stepX = 1,
                stepY = 1;

            InitializeMatrix(numberOfRows, matrix, ref number, ref row, ref col, ref stepX, ref stepY);

            FindNullCell(matrix, out row, out col);

            stepX = 1;
            stepY = 1;

            InitializeMatrix(numberOfRows, matrix, ref number, ref row, ref col, ref stepX, ref stepY);

            PrintMatrix(numberOfRows, matrix);
        }

        public static void ChangeDirections(ref int stepX, ref int stepY)
        {
            int currentDirection = 0;
            for (int index = 0; index < countNumber; index++)
            {
                if (directionX[index] == stepX && directionY[index] == stepY)
                {
                    currentDirection = index;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                stepX = directionX[0];
                stepY = directionY[0];
                return;
            }
            else
            {
                stepX = directionX[currentDirection + 1];
                stepY = directionY[currentDirection + 1];
            }
        }

        public static bool Check(int[,] matrix, int row, int col)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < countNumber; i++)
            {
                int curElemX = dirX[i];
                int curElemY = dirY[i];

                if (row + curElemX >= matrix.GetLength(0) || row + curElemX < 0)
                {
                    curElemX = 0;
                }

                if (col + curElemY >= matrix.GetLength(0) || col + curElemY < 0)
                {
                    curElemY = 0;
                }

                if (matrix[row + curElemX, col + curElemY] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindNullCell(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        public static void PrintMatrix(int numberOfRows, int[,] matrix)
        {
            for (int p = 0; p < numberOfRows; p++)
            {
                for (int q = 0; q < numberOfRows; q++)
                {
                    Console.Write("{0,4}", matrix[p, q]);
                }

                Console.WriteLine();
            }
        }

        public static void InitializeMatrix(int numberOfRows, int[,] matrix, ref int number, ref int row, ref int col, ref int stepX, ref int stepY)
        {
            while (true)
            {
                matrix[row, col] = number;
                number++;

                if (Check(matrix, row, col))
                {
                    if (IsInTheMatrix(numberOfRows, row, col, stepX, stepY) || matrix[row + stepX, col + stepY] != 0)
                    {
                        while (IsInTheMatrix(numberOfRows, row, col, stepX, stepY) || matrix[row + stepX, col + stepY] != 0)
                        {
                            ChangeDirections(ref stepX, ref stepY);
                        }
                    }

                    row += stepX;
                    col += stepY;
                }
                else
                {
                    break;
                }
            }
        }

        private static bool IsInTheMatrix(int numberOfRows, int row, int col, int stepX, int stepY)
        {
            return row + stepX >= numberOfRows || row + stepX < 0 || col + stepY >= numberOfRows || col + stepY < 0;
        }
    }
}