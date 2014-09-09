using System;
//Write a program that reads two numbers N and K and generates 
//all the combinations of K distinct elements from the set [1..N].
// Example: N = 5, K = 2 ->
//{1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

class CombinationsOfK
{
    static void Main()
    {
        Console.WriteLine("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K: ");
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
            for (int j = 1; j < array.Length; j++)
            {
                if (array[i] != array[j])
                {
                    Console.WriteLine("({0}, {1}) ", array[i], array[j]);
                }                
            }
        }
    }
}

