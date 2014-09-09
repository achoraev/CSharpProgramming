using System;

    class NullValue
    {
        static void Main()
        {
            int? first = null;
            double? second = null;
            Console.WriteLine(first + " " + second);
            first = 25;
            second = 45;
            Console.WriteLine(first + " " + second);
            first = 0;
            second = 0;
            Console.WriteLine(first + " " + second);
        }
    }

