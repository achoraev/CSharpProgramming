using System;

class ShowSign
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber >= 0)
        {
            Console.WriteLine("The first number is with sign \" + \"");
        }
        else
        {
            Console.WriteLine("The first number is with sign \" - \"");
        }
        if (secondNumber >= 0)
        {
            Console.WriteLine("The second number is with sign \" + \"");
        }
        else
        {
            Console.WriteLine("The second number is with sign \" - \"");
        }
        if (thirdNumber >= 0)
        {
            Console.WriteLine("The third number is with sign \" + \"");
        }
        else
        {
            Console.WriteLine("The third number is with sign \" - \"");
        }
    }
}