using System;
//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class MethodReadNumber
{
    static void Main()
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                ReadNumber(num);
            }            
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid number!!!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!!!");
        }       
    }

    static void ReadNumber(int number)
    {
        if (number < 1 || number > 100)
        {
            throw new IndexOutOfRangeException("Invalid number!!!");
        }
    }
}

