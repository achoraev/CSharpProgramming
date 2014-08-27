using System;

class AngryBits
{
    static void Main()
    {
        int[,] matrix = new int[8, 16];

        FillMatrix(matrix);

        int cells = 0;
        int counter = 0;
        int currentRow = 0;
        int currentCol = 0;
        int result = 0;
        for (int col = 8; col < 16; col++)// find Bird
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)//found bird
                {
                    matrix[row, col] = 0;
                    currentRow = row;
                    currentCol = col;
                    counter = 0;
                    cells = 0;

                    for (int j = col - 1; j >= 1; j--)// Birds fly to top
                    {
                        if (currentRow <= 0 || currentCol <= 0)
                        {
                            break;
                        }
                        if (matrix[currentRow, currentCol] == 1)//Hit Pig
                        {
                            for (int k = currentRow + 1; k >= currentRow - 1; k--)//count around hit
                            {
                                if (currentRow < 0)
                                {
                                    k++;
                                }
                                else if (currentRow > 7)
                                {
                                    k--;
                                }
                                    for (int l = currentCol - 1; l <= currentCol + 1; l++)
                                    {
                                        if (currentCol < 0)
                                        {
                                            l++;
                                        }
                                            else if (currentCol > 7)
                                            {
                                                l--;
                                            }
                                        if (matrix[k, l] == 1)
                                        {
                                            counter++;
                                            matrix[k, l] = 0;
                                        }
                                    }
                            }
                            break;
                        }
                        currentRow--;
                        currentCol--;
                        cells++;
                    }
                    
                    for (int i = currentCol; i >= 0; i--)// Birds fly to bottom
                    {
                        if (currentRow > 7 || currentCol < 0)
                        {
                            break;
                        }
                        if (matrix[currentRow, currentCol] == 1)//Hit Pig
                        {
                            for (int k = (currentRow + 1); k >= (currentRow - 1); k--)//count around hit
                            {
                                if (k < 0)
                                {
                                    k++;
                                }
                                else if (k > 7)
                                {
                                    k--;
                                }
                                    for (int l = (currentCol + 1); l >= (currentCol - 1); l--)
                                    {
                                        if (l < 0)
                                        {
                                            l++;
                                        }
                                            else if (l > 7)
                                            {
                                                l--;
                                            }
                                        if (matrix[k, l] == 1)
                                        {
                                            counter++;
                                            matrix[k, l] = 0;
                                        }
                                    }
                                    
                            }                            
                            break;
                            
                        }
                        currentRow++;
                        currentCol--;
                        cells++;
                    }
                    result = (counter * cells);
                    
                }                
            }
            
        }

        //PrintMatrix(matrix);
        result += (counter * cells);
        //Console.WriteLine(cells);
        //Console.WriteLine(counter);
        Console.WriteLine("{0} Yes", result);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < 8; row++)//print matrix
        {
            for (int col = 15; col >= 0; col--)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void FillMatrix(int[,] matrix)
    {
        for (int row = 0; row < 8; row++)//Fill matrix
        {
            int num = int.Parse(Console.ReadLine());
            for (int col = 0; col < 16; col++)
            {
                int mask = (num >> col & 1);
                if (mask == 1)
                {
                    matrix[row, col] = 1;
                }
            }
        }
    }
}