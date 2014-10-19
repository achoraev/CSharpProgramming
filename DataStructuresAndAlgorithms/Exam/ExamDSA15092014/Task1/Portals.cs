namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Portals
    {
        static int[,] matrix;
        public static void Main()
        {            
            string[] startingPosition = Console.ReadLine().Split(' ');
            int startX = int.Parse(startingPosition[0].ToString());
            int startY = int.Parse(startingPosition[1].ToString());
            string[] matrixSize = Console.ReadLine().Split(' ');
            int matrixRows = int.Parse(matrixSize[0].ToString());
            int matrixCols = int.Parse(matrixSize[1].ToString());

            matrix = new int[matrixRows, matrixCols];


            for (int rows = 0; rows < matrixRows; rows++)
            {
                string[] inputRow = Console.ReadLine().Split(' ');
                for (int cols = 0; cols < matrixCols; cols++)
                {
                    if (inputRow[cols] != "#")
                    {
                        matrix[rows, cols] = int.Parse(inputRow[cols]);
                    }
                    else
                    {
                        matrix[rows, cols] = -1;
                    }
                }
            }



        }
    }
}