using System;
//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located
// on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 

class LongestSequence
{
	static void Main()
	{		
		string[,] rectangular = {
			{"ha", "fifi", "ho", "hi"},
			{"fo", "ha", "hi", "xx"},
			{"xxx", "ho", "ha", "xx"}
			};
		int length = 1;
		int bestLength = 1;	
		string longElement="";
		
		//check rows		
		for (int row = 0; row < rectangular.GetLength(0); row++)
		{
			for (int col = 0; col < rectangular.GetLength(1); col++)
			{
				if (col+1 == rectangular.GetLength(1))
				{
					length = 1;
					break;
				}
				else if (rectangular[row, col] == rectangular[row, col+1])
				{
					length++;
					if (length > bestLength)
					{
						bestLength = length;
						longElement = rectangular[row, col];
					}					
				}
				
			}			
		}
		//check cols		
		for (int col = 0; col < rectangular.GetLength(1); col++)
		{
			for (int row = 0; row < rectangular.GetLength(0); row++)
			{
				if (row+1 == rectangular.GetLength(0))
				{
					length = 1;
					break;
				}
				else if (rectangular[row, col] == rectangular[row+1, col])
				{
					length++;
					if (length > bestLength)
					{
						bestLength = length;
						longElement = rectangular[row, col];
					}	
				}
				
			}			
		}
		//check diagonals from left to right only from center diagonal up	
        int count = 0;
        for (int col = 0, row = 0; col < rectangular.GetLength(1) - 1; col++)
        {
            for (row = 0; row < rectangular.GetLength(0) - 1; row++)
            {
                if (col == rectangular.GetLength(1) - 1)
                {
                    length = 1;
                    break;
                }
                else if (rectangular[row, col] == rectangular[row + 1, col + 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        longElement = rectangular[row, col];
                    }
                }
                col++;
            }
            col = count;
            row = 0;
            count++;
        }						
		// print long sequence
        PrintLongSequence(bestLength, longElement);
	}

    private static void PrintLongSequence(int bestLength, string longElement)
    {
        Console.Write("Longest sequence is: "); 
        for (int i = 0; i < bestLength; i++)
        {
            if (i < bestLength-1)
            {
               Console.Write("{0}, ", longElement); 
            }
            else
            {
                Console.Write("{0}", longElement);
            }
            
        }
        Console.WriteLine();
    }
}