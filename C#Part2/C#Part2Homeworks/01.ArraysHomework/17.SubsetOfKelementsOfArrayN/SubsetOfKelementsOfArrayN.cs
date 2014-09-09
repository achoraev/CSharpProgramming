using System;
//*Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.

class SubsetOfKelementsOfArrayN
{
    public static int Kelement = 0;

    static void Main()
    {
        Console.WriteLine("Enter size of Array: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many elements: ");
        int Kelement = int.Parse(Console.ReadLine());
        if (Kelement > numberN)
        {
            Console.WriteLine("Wrong number. Must be smaller from size of Array.");
        }
        Console.WriteLine("Enter sum: ");
        int sumS = int.Parse(Console.ReadLine());
        int[] numbers = new int [numberN];
        int[] positionArray = new int [numberN];
        int tempSum = 0;
        int count = 0;
        int position = 0;
        
        FillArray(numberN, numbers);

        // Solution
        
        Array.Sort(numbers);
        for (position = 0; position < numbers.Length; position++)
        {
            tempSum += numbers[position];
            count++;
            if (count == Kelement && tempSum != sumS)
            {
                count = 0;
                positionArray[position] = numbers[position];
                tempSum = numbers[position];
            }
            else if (tempSum == sumS)
            {
                Console.WriteLine("The sum: {0}", tempSum);
                positionArray[position] = numbers[position];
                Console.WriteLine("Sequence: ");
                break;
            }
            else if (tempSum > sumS)
            {
                tempSum -= numbers[position];
            }
            else
            {
                positionArray[position] = numbers[position];
            }
        }
        //print
        for (int i = position; i > position-Kelement; i--)
        {
            Console.Write("{0},", positionArray[i]);
        }
        Console.WriteLine();
    }

    private static void FillArray(int numberN, int[] numbers)
    {
        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine("Enter elements: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
    } 
}