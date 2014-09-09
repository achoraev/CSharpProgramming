using System;

class NestedStatements
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        int bigNumber = firstNumber;
            if (firstNumber < secondNumber)
            {
                bigNumber = secondNumber;
            }
            if (thirdNumber > secondNumber)
            {
                bigNumber = thirdNumber;
            }
            if (firstNumber == secondNumber || secondNumber == thirdNumber)
            {
                Console.WriteLine("There is have Equal Numbers!!!");
            }   
            Console.WriteLine("The Biggets number is: " + bigNumber);                        
    }
}