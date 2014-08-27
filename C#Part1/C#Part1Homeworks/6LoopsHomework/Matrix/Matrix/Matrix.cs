using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        int[,] array = new int[number, number];
        int value = 1;
        int row = 0;
        int col = 0;

        while (true)
        {
            array[row, col] = value;
            if (col < number - 1 && row == 0)
            {
                col++;                
            }
            else if (row < number - 1 && col == number - 1)
            {
                row++;                
            }
            else if (col > 0 && row == number - 1)
            {
                col--;                
            }
            else if (row > 1 && col == 0)
            {
                row--;                
            }
            else if (col < number - 2 && row == 1)
            {
                col++;                
            }
            else if (row < number - 2 && col == number - 2)
            {
                row++;                
            }
            else if (array[row+1, col] > 0)
            { 
                col--;                
            }
            else if (array[row, col+1] > 0)
            {
                row--;
            }
            value++;
            
            if (value == 25)
            {
                break;
            }
        }
        // print
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0,4}", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
