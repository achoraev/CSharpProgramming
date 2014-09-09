using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class DogeCoin
{
    static void Main()
    {
        //read input
        string[] inputNAndM = Console.ReadLine().TrimEnd().Split();
        long numberN = long.Parse(inputNAndM[0]);
        long numberM = long.Parse(inputNAndM[1]);
        long numberK = long.Parse(Console.ReadLine());
        List<long> coordinates = new List<long>();
        for (int i = 0; i < numberK; i++)
        {
            string[] rows = Console.ReadLine().TrimEnd().Split();
            coordinates.Add(long.Parse(rows[0]));
            coordinates.Add(long.Parse(rows[1]));
        }

        //solution
        long[,] matrix = new long[numberN, numberM];
        for (int i = 0; i < coordinates.Count; i += 2)
        {
            matrix[coordinates[i], coordinates[i + 1]] += 1;
        }
        long result = 0;
        for (int row = 0; row < 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result += matrix[row, col];
            }
        }
        for (int row = 0; row < 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                result += matrix[col, row];
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            result += matrix[row, matrix.GetLength(1) - 1];
        }
        
        //print result
        Console.WriteLine(result);

    }
}