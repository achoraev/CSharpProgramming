using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of Matrix:");
        int number = int.Parse(Console.ReadLine());
        int numberCount =  0;
        if (number > 20)
        {
            Console.WriteLine("Wrong Number!! must between 0 - 20!!!");
        }
        else
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = row; col <= number + numberCount; col++)
                {
                    Console.Write("{0,3}", col);                    
                }
                Console.WriteLine();
                numberCount += 1;
            }
        }        
    }
}