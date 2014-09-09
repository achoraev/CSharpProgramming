using System;
using System.IO;
//Write a program that reads a text file containing a square matrix of numbers 
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
/*4
2 3 3 4
0 2 3 4	  ->	17
3 7 1 2
4 3 3 2*/

class ReadMatrix
{
    static void Main()
	{
		string path = "...\\...\\matrix.txt";
        StreamReader reader = new StreamReader(path);
		int size = int.Parse(reader.ReadLine());
        int[,] matrix = new int[size, size];
        string[] sizeArray = new string[size];

        for (int i = 0; i < size; i++)
		{
            sizeArray = reader.ReadLine().Split();
            for (int j = 0; j < size; j++)
            {                
                matrix[i, j] = int.Parse(sizeArray[j]);
            }
		}
        int result = MaximalSumInMatrixTwoOnTwo(matrix);
		StreamWriter writer = new StreamWriter("result.txt");
        writer.WriteLine(result);// chech folder: .....\bin\Debug for result
        writer.Close();
        reader.Close();
		
	}

    private static int MaximalSumInMatrixTwoOnTwo(int[,] matrix)
    {
        int result = 0;
        int sum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col + 1 == matrix.GetLength(1) || row + 1 == matrix.GetLength(0))
                {
                    break;
                }
                sum += matrix[row, col] + matrix[row, col + 1] +
                       matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > result)
                {
                    result = sum;
                }
                sum = 0;
            }
        }
        return result;
    }
}