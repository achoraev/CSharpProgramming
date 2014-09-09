using System;

    class GreatestNumberFromFive
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());

            double BiggestNumber = firstNumber;
            if (BiggestNumber < secondNumber)
            {
                BiggestNumber = secondNumber;
            }
            if (BiggestNumber < thirdNumber)
            {
                BiggestNumber = thirdNumber;
            }
            if (BiggestNumber < fourthNumber)
            {
                BiggestNumber = fourthNumber;
            }
            if (BiggestNumber < fifthNumber)
            {
                BiggestNumber = fifthNumber;
            }
            Console.WriteLine("The greatest variable is: {0}", BiggestNumber);
        }
    }

