using System;

    class QuotedStrings
    {
        static void Main()
        {
            string text = "The \"use\" of quotations causes difficulties";
            string without = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(text);
            Console.WriteLine(without);
        }
    }
