using System;

    class BooleanExpression
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (number % 5 == 0 && number % 7 == 0)
                {
                    Console.WriteLine("Number is delete to 5 and 7");
                }
                    else
                    {
                        Console.WriteLine("Number isn't delete to 5 or 7");
                    }  
            
            }
        }
    }
