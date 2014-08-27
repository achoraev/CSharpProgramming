using System;
using System.Threading;

    class SwitchDoubleOrString
    {
        
        static void Main()
        {
            Console.WriteLine("Enter 1 for int variable, 2 for double and 3 for string:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter int variable:");
                    int intVar = int.Parse(Console.ReadLine());
                    intVar += 1; 
                    Console.WriteLine(intVar); break;
                case 2:
                    Console.WriteLine("Enter double variable:");
                    double doubleVar = double.Parse(Console.ReadLine());
                    doubleVar += 1;
                    Console.WriteLine(doubleVar); break;
                case 3:
                    Console.WriteLine("Enter string:");
                    string stringVar = Console.ReadLine();                    
                    Console.WriteLine(stringVar + "*"); break;
                default: Console.WriteLine("Error: Number must be between 1 - 3 "); break;
            }
        }
    }

