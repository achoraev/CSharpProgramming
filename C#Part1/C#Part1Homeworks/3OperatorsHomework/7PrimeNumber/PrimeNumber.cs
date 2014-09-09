using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Write Number Between 1 and 100");
        int number = int.Parse(Console.ReadLine());
        if ((number > 1) && (number <= 100))
        {
            if ((number == 2) || (number == 3) || (number == 5) || (number == 7))
            {
                Console.WriteLine("Number {0} is Prime ", number);
            }
            else
            {
                if (((number % 2) != 0) && ((number % 3) != 0) && ((number % 5) != 0) && ((number % 7) != 0))
                {
                    Console.WriteLine("Number {0} is Prime ", number);
                }
                else
                {
                    Console.WriteLine("{0} not Prime ", number);
                }
            }
        }
        else
        {
            Console.WriteLine("Number is not Between 1 and 100");
        }
    }
}