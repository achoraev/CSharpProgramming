using System;
//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class CalculateAndPrintSqrt
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                double result = Math.Sqrt(num);
                Console.WriteLine("Square root is: {0:F2}", result); 
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!!!");
        }
        
    }
}

