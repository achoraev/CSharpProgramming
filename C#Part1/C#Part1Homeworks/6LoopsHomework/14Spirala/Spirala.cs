using System;

class Spirala
{
    static void Main()
    {
        Console.WriteLine("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        int [,] array = new int[number,number];  		
		int value = 1;
		int row = 0;
		int col = 0;      
        for (int i = col; i < number-1; i++)// first row
        {
            array [row, col] = value;
            value ++;
            col++;
        }            
            for (int j = row; j < number-1; j++)// last col
            {                
                array[row, col] = value;
                value++;
                row++;
            }
                for (int k = col; k > 0; k--)// last row
                {
                    array[row, col] = value;
                    value++;
                    col--;
                }
                    for (int l = row; l > 1; l--)// first col
                    {
                        array[row, col] = value;
                        value++;
                        row--;
                    }
                        for (int m = col; m < number-1; m++)// second row
                        {
                            array[row, col] = value;
                            value++;
                            col++;
                        }
                            for (int n = row; n < number - 2; n++)// inner col
                            {
                                array[row+1, col-1] = value;
                                value++;
                                row++;
                            }
                // Print Matrix
			    for (int i = 0; i <= (number-1); i ++)
			    {		
				for (int j = 0; j <= (number-1); j++)
				{
				Console.Write("{0,4}", (array[i, j]));	
				}
				Console.WriteLine();
			}			
	}			
}
