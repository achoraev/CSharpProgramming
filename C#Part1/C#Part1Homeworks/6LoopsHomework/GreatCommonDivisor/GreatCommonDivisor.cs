using System;

class GreatCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Enter first Number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int gcd;

        if (firstNumber > secondNumber)
        {
            for (int i = 0; firstNumber > secondNumber; i++)
            {
                firstNumber = firstNumber - secondNumber;

                for (int j = 0; secondNumber > firstNumber; j++)
                {
                    secondNumber = secondNumber - firstNumber;
                }
            }
        }

        if (secondNumber > firstNumber)
        {
            for (int j = 0; secondNumber > firstNumber; j++)
            {
                secondNumber = secondNumber - firstNumber;

                for (int i = 0; firstNumber > secondNumber; i++)
                {
                    firstNumber = firstNumber - secondNumber;
                }
            }
        }

        if (firstNumber == secondNumber)
        {
            gcd = firstNumber;
            Console.WriteLine("Greatest common divisor is: " + gcd);
        }

    }
}