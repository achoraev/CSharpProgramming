using System;

class Cards
{
    static void Main()
    {
        for (int j = 0; j <= 3; j++) 
        {
            for (int i = 2; i <= 14; i++)
            {
                if (i > 10)
                {
                    switch (i % 10)
                    {
                        case 1: Console.Write("Jack  "); break;
                        case 2: Console.Write("Queen "); break;
                        case 3: Console.Write("King  "); break;
                        case 4: Console.Write("Ace   "); break;
                    }
                       
                }
                    else
                    {
                        Console.Write("{0,5} ", i);
                    }
                    switch (j)
                    {
                        case 0: Console.Write("of Hearts"); break;
                        case 1: Console.Write("of Diamonds"); break;
                        case 2: Console.Write("of Clubs"); break;
                        case 3: Console.Write("of Spades"); break;
                    }
                    Console.WriteLine();
            }
        }
    }
}