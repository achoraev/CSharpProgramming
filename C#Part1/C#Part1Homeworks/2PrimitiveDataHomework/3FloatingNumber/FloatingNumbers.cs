using System;

    class FloatingNumbers
    {
        static void Main()
        {
            float first = 5.3f;
            float second = 6.01f;
            double third = 5.00000001;
            double fourth = 5.00000003;
            bool equalFloat = (first > second);
            bool equalDouble = (third < fourth);
            Console.WriteLine(equalFloat);
            Console.WriteLine(equalDouble);
        }
    }
