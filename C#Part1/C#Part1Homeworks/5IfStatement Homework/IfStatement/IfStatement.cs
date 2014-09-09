using System;

class IfStatement
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine
            ("First number now is {0} and second number is: {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Second number is greater than first.");
        }        
    }
}
