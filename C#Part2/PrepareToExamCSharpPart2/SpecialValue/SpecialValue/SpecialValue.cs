using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpecialValue
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine().Trim());
        int[] numbers;
        for (int row = 0; row < rows; row++)
        {
            string []input = Console.ReadLine().Split(new char [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            numbers = new int [input.Length];
            int rowLength = input.Length;
            for (int cols = 0; cols  < input.Length; cols ++)
            {                                                
               
            }
        }
    }
}

