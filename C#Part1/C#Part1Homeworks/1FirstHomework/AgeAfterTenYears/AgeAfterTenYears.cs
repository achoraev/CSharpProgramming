using System;

    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Your Age is:");
            int age = int.Parse(Console.ReadLine ());
            if (age >= 0 && age <= 130)
            {
                Console.WriteLine("Your Age is: " + age);
                Console.WriteLine("Your Age After 10 Years is: " + (age + 10));
            }
            else
            {
                Console.WriteLine("Your Age must be between 0 and 130 years");
            }        
        }
    }
