// 3.What is the expected running time of the following C# code? Explain why.
// Assume the input matrix has size of n * m.
long CalcSum(int[,] matrix, int row)
{
    long sum = 0;
    for (int col = 0; col < matrix.GetLength(1); col++) 
	{
        sum += matrix[row, col];		
	}
    if (row + 1 < matrix.GetLength(0)) 
	{
        sum += CalcSum(matrix, row + 1);
	}
    return sum;
}

Console.WriteLine(CalcSum(matrix, 0));

// The complexity of the algorithm(worst scenario) is: O(n * m)
// We run recursively through each of the rows of the matrix which is (n-row) steps
// We run through the columns which is m steps.