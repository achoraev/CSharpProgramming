using System;
//Write a program that reads two numbers N and K and generates all the variations of K elements
// from the set [1..N]. 
//Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

class AllVariationOfK
{
    static void Main()
    {
        Console.WriteLine("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K < N: ");
        int numberK = int.Parse(Console.ReadLine());        

        int[] array = new int[numberN];
        for (int i = 0; i < array.Length; i++)// fill array
        {
            array[i] = i+1;          
        }
        
        PrintArray(numberK, array);
        Console.ReadLine();
    }

    private static void PrintArray(int numberK, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j <= numberK; j++)
            {
                Console.WriteLine("({0}, {1}) ", array[i], array[j]);
            }
        }
    }
}

