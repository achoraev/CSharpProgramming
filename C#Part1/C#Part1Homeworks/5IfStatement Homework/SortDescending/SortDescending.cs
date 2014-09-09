using System;

class SortDescending
{
    static void Main()
    {
        Console.WriteLine("A:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("B:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("C:");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
        }

    }
}

