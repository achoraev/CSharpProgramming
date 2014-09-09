using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Digits
{
    static void Main()
    {
        //read input
        int numberOfRows = int.Parse(Console.ReadLine());
        long [,] matrix = new long[numberOfRows, numberOfRows];
        for (int row = 0; row < numberOfRows; row++)
        {
            string[] inputNumbers = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < numberOfRows; col++)
            {
                matrix[row, col] = long.Parse(inputNumbers[col]);
            }
        }
        //solution
        long result = 0;
        //result += CheckForZeroPattern(matrix, numberOfRows);
        result += CheckForOnePattern(matrix, numberOfRows)*1;
        result += CheckForTwoPattern(matrix, numberOfRows)*2;
        result += CheckForThreePattern(matrix, numberOfRows)*3;
        result += CheckForFourPattern(matrix, numberOfRows)*4;       
        result += CheckForFivePattern(matrix, numberOfRows)*5;
        result += CheckForSixPattern(matrix, numberOfRows)*6;
        result += CheckForSevenPattern(matrix, numberOfRows)*7;
        result += CheckForEightPattern(matrix, numberOfRows)*8;
        result += CheckForNinePattern(matrix, numberOfRows)*9;

        // print result
        Console.WriteLine(result);
    }

    static long CheckForNinePattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 9)
                {
                    continue;
                }
                else if    (matrix[row, col] == 9
                    && matrix[row, col + 1] == 9
                    && matrix[row, col + 2] == 9
                    && matrix[row + 1, col + 2] == 9
                    && matrix[row + 2, col + 2] == 9
                    && matrix[row + 3, col + 2] == 9
                    && matrix[row + 4, col + 2] == 9
                    && matrix[row + 4, col] == 9
                    && matrix[row + 4, col + 1] == 9                   
                    && matrix[row + 1, col] == 9                    
                    && matrix[row + 2, col + 1] == 9)
                {
                    result += 1;
                }
                
            }
        }
        return result;
    }

    static long CheckForEightPattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 8)
                {
                    continue;
                }
                else if    (matrix[row, col] == 8
                    && matrix[row, col + 1] == 8
                    && matrix[row, col + 2] == 8
                    && matrix[row + 1, col+2] == 8
                    && matrix[row + 3, col+2] == 8
                    && matrix[row + 4, col+2] == 8
                    && matrix[row + 4, col] == 8
                    && matrix[row + 4, col + 1] == 8
                    && matrix[row + 4, col + 2] == 8
                    && matrix[row + 1, col] == 8
                    && matrix[row + 3, col] == 8                  
                    && matrix[row + 2, col + 1] == 8)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }

    static long CheckForSevenPattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 7)
                {
                    continue;
                }
                else if    (matrix[row, col] == 7
                    && matrix[row, col + 1] == 7
                    && matrix[row, col + 2] == 7
                    && matrix[row + 1, col+2] == 7
                    && matrix[row + 2, col+1] == 7
                    && matrix[row + 3, col+1] == 7
                    && matrix[row + 4, col+1] == 7)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }

    static long CheckForSixPattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 6)
                {
                    continue;
                }
                else if    (matrix[row, col] == 6
                    && matrix[row, col + 1] == 6
                    && matrix[row, col + 2] == 6
                    && matrix[row + 1, col] == 6
                    && matrix[row + 2, col] == 6
                    && matrix[row + 3, col] == 6
                    && matrix[row + 4, col] == 6
                    && matrix[row + 4, col + 1] == 6
                    && matrix[row + 4, col + 2] == 6                    
                    && matrix[row + 3, col + 2] == 6
                    && matrix[row + 2, col + 2] == 6
                    && matrix[row + 2, col + 1] == 6)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }

    static long CheckForFivePattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 5)
                {
                    continue;
                }
                else if (matrix[row, col] == 5
                    && matrix[row, col + 1] == 5
                    && matrix[row, col + 2] == 5
                    && matrix[row + 1, col] == 5
                    && matrix[row + 2, col] == 5
                    && matrix[row + 2, col + 1] == 5
                    && matrix[row + 2, col + 2] == 5
                    && matrix[row + 3, col + 2] == 5
                    && matrix[row + 4, col + 2] == 5
                    && matrix[row + 4, col + 1] == 5
                    && matrix[row + 4, col] == 5)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }

    static long CheckForFourPattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 4)
                {
                    continue;
                }
                else if (matrix[row, col] == 4
                    && matrix[row + 1, col] == 4
                    && matrix[row + 2, col] == 4
                    && matrix[row + 2, col + 1] == 4
                    && matrix[row, col + 2] == 4
                    && matrix[row + 1, col + 2] == 4
                    && matrix[row + 2, col + 2] == 4
                    && matrix[row + 3, col + 2] == 4
                    && matrix[row + 4, col + 2] == 4)
                {
                    result += 1;
                }
            }
        }
        return result;
    }

    static long CheckForThreePattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row, col] != 3)
                {
                    continue;
                }
                else if    (matrix[row, col] == 3
                    && matrix[row, col + 1] == 3
                    && matrix[row, col + 2] == 3
                    && matrix[row + 1, col + 2] == 3
                    && matrix[row + 2, col + 2] == 3
                    && matrix[row + 3, col + 2] == 3
                    && matrix[row + 4, col + 2] == 3
                    && matrix[row + 4, col + 1] == 3
                    && matrix[row + 4, col] == 3
                    && matrix[row + 2, col+1] == 3)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }

    static long CheckForTwoPattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;
        for (int row = 0; row < numberOfRows - 4; row++)
        {
            for (int col = 0; col < numberOfRows - 2; col++)
            {
                if (matrix[row+1, col] != 2)
                {
                    continue;
                }
                else if (matrix[row+1, col] == 2
                    && matrix[row, col+1] == 2
                    && matrix[row + 1, col+2] == 2
                    && matrix[row + 2, col + 2] == 2
                    && matrix[row + 3, col + 1] == 2
                    && matrix[row+4, col] == 2
                    && matrix[row + 4, col + 1] == 2
                    && matrix[row + 4, col + 2] == 2)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }
    
    //static long CheckForZeroPattern(long[,] matrix, int numberOfRows)
    //{
    //    long result = 0;
    //    for (int row = 0; row < numberOfRows - 4; row++)
    //    {
    //        for (int col = 0; col < numberOfRows - 2; col++)
    //        {
    //            if    (matrix[row, col] == 0
    //                && matrix[row, col + 1] == 0
    //                && matrix[row, col + 2] == 0
    //                && matrix[row + 1, col] == 0
    //                && matrix[row + 2, col] == 0
    //                && matrix[row + 3, col] == 0
    //                && matrix[row + 4, col] == 0                    
    //                && matrix[row + 4, col + 1] == 0
    //                && matrix[row + 4, col + 2] == 0                    
    //                && matrix[row + 3, col + 2] == 0
    //                && matrix[row + 2, col + 2] == 0
    //                && matrix[row + 1, col + 2] == 0)
    //            {
    //                result += 1;
    //            }
    //            else
    //            {
    //                continue;
    //            }
    //        }
    //    }
    //    return result;
    //}

    static long CheckForOnePattern(long[,] matrix, int numberOfRows)
    {
        long result = 0;        
        for (int row = 0; row < numberOfRows-4; row++)
        {
            for (int col = 0; col < numberOfRows-2; col++)
            {
                if (matrix[row, col+2] != 1)
                {
                    continue;
                }
                else if    (matrix[row, col+2] == 1
                    && matrix[row +1, col + 2] == 1
                    && matrix[row +2, col + 2] == 1
                    && matrix[row +3, col + 2] == 1
                    && matrix[row +4, col + 2] == 1
                    && matrix[row+2, col] == 1
                    && matrix[row + 1, col + 1] == 1)
                {
                    result += 1;
                }                
            }
        }
        return result;
    }
}