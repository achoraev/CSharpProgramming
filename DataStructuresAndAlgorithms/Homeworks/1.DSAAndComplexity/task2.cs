// 2.What is the expected running time of the following C# code? Explain why.
// Assume the input matrix has size of n * m.
long CalcCount(int[,] matrix)
{
    long count = 0;
    for (int row=0; row<matrix.GetLength(0); row++)
        if (matrix[row, 0] % 2 == 0)
            for (int col=0; col<matrix.GetLength(1); col++)
                if (matrix[row,col] > 0)
                    count++;
    return count;
}

// The complexity of the algorithm(worst scenario) is: O(n * m)
// Once we cycle through the whole array with length n.
// Secondary we go through a second cycle which contains (m) steps.
// The second cycle depends on variable parameter a. 
// After we remove the parameter we have the following complexity: 0(n*m)