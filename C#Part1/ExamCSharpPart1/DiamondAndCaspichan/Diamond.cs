using System;

class Diamond
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int width = (numberN * 2) + 1;
        int heigth = (6 + ((numberN - 3) / 2 * 3));
        int[,] array = new int[heigth, width];

        //fill with 0
        for (int row = 0; row < heigth; row++)
        {
            for (int col = 0; col < width; col++)
            {
                array[row, col] = 0;
            }
        }
        //solution
        // top part
        int colTop = 1;
        for (int row = numberN / 2; row >= 0; row--)//left
        {
            array[row, colTop] = 1;
            colTop++;
        }
        for (int col = colTop; col < colTop + (numberN - 1); col++)//top
        {
            array[0, col] = 1;

        }
        int colRight = colTop + (numberN - 1);
        for (int row = 1; row < (numberN / 2 + 1); row++)//right
        {
            array[row, colRight] = 1;
            colRight++;
        }
        for (int row = 0; row < numberN / 2 + 1; row++)//middle
        {
            array[row, numberN] = 1;
        }

        for (int col = 0; col < width; col++) // middle part
        {
            array[(numberN / 2 + 1), col] = 1;
        }

        int currentRow = (numberN / 2 + 1) + 1; // bottom part   
        for (int col = 1; col < width; col++) // left side
        {
            if (currentRow >= heigth)
            {
                break;
            }
            else
            {
                array[currentRow, col] = 1;
                currentRow++;
            }
        }

        for (int row = (numberN / 2 + 1) + 1; row < heigth; row++)//middle
        {
            array[row, numberN] = 1;
        }
        currentRow -= 2;
        for (int col = numberN + 1; col < width; col++) // right side
        {
            array[currentRow, col] = 1;
            currentRow--;
        }

        // print
        for (int row = heigth-1; row >= 0; row--)
        {
            for (int col = 0; col < width; col++)
            {
                if (array[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (array[row, col] == 1)
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine();
        }
    }
}

