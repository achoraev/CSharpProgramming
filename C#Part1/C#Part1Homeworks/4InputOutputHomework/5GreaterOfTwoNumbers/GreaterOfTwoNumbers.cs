using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(secondNumber > firstNumber ?
        "Number {1} is greater then {0}" : "Number {0} is greater then {1}", firstNumber, secondNumber);
    }
}