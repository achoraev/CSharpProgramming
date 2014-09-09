using System;

class ANacii
{
    static void Main()
    {
        string firstLetter = Console.ReadLine();
        string secondLetter = Console.ReadLine();
        int numberRows = int.Parse(Console.ReadLine());
        int realFirstLetter = firstLetter[0];
        int realSecondLetter = secondLetter[0];
        int nextNumber = 0;
        int row = 2;
        int col = 0;

        if (numberRows == 1)
        {
            Console.WriteLine(firstLetter);
        }
        else
        {
            Console.WriteLine(firstLetter);
            for (row = 2; row <= numberRows; row++)
            {
                for (col = 0; col < 2; col++)
                {

                    if (realFirstLetter > 90)
                    {
                        realFirstLetter -= 25;
                    }
                    else if (realSecondLetter > 90)
                    {
                        realSecondLetter -= 26;
                    }
                   
                    Console.Write((char)realSecondLetter);
                    if (row > 2 && col < 1)
                    {
                        for (int k = 2; k < row; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                    nextNumber = realFirstLetter + realSecondLetter;
                    if (nextNumber > 90)
                    {
                        nextNumber = (nextNumber % 26) + 66;
                    }
                    realFirstLetter = realSecondLetter;
                    realSecondLetter = nextNumber;
                }
                Console.WriteLine();
            }
        }
    }
}