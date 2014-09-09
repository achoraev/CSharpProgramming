// 1.What is the expected running time of the following C# code? Explain why. Assume the array's size is n.
long Compute(int[] arr)
{
    long count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        int start = 0, end = arr.Length-1;
        while (start < end)
            if (arr[start] < arr[end])
                { 
					start++; 
					count++;
				}
            else 
                end--;
    }
    return count;
}

// The complexity of the algorithm is: O(n * n)
// Once we cycle through the whole array with length n.
// Secondary we go through a while cycle which contains (n-1) steps.