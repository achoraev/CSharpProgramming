using System;

    class DrunkenNumbers
    {
        static void Main()
        {            
            int rounds = int.Parse(Console.ReadLine());
            if (rounds < 1 && rounds > 100)
            {
                Console.WriteLine("Wrong Number!!!");
            }            
            int delitel = 10;
            int mitkoSum = 0;
            int vladkoSum = 0;            
            for (int i = 0; i < rounds; i++)
            {
                int number = int.Parse(Console.ReadLine());             
                if (number > 999999999)
                {
                    Console.WriteLine("Wrong Number!!!");
                }
                if (number < 0)
                {
                    number *= -1;
                }
                int currentNumber = number;
                int NumberDigit = 0;    
                    for (int j = 0; j < 10; j++)
                    {                    
                        if (currentNumber > 0)
                        {                            
                            currentNumber = currentNumber / 10;
                            NumberDigit++;
                        }                    
                    }                                  
                        for (int k = 0; k < (NumberDigit/2); k++)
                        {
                            int rightDigit = number % delitel;
                            number = number / delitel;
                            vladkoSum += rightDigit;                             
                        }
                        if (NumberDigit % 2 != 0)
                        {
                            int middleDigit = number % 10;
                            vladkoSum += middleDigit;
                            mitkoSum += middleDigit;
                            number = number / delitel;
                        }
                        for (int l = 0; l < (NumberDigit / 2); l++)
                            {
                                int leftDigit = number % delitel;
                                number = number / delitel;
                                mitkoSum += leftDigit;          
                            }                                                    
            }
            if (vladkoSum > mitkoSum)
            {
                Console.WriteLine("V"+" "+(vladkoSum - mitkoSum));
            }
            else if (vladkoSum < mitkoSum)
            {
                Console.WriteLine("M"+" "+(mitkoSum - vladkoSum));
            }
            else
            {
                Console.WriteLine("No"+" "+(mitkoSum + vladkoSum));
            }
        }
    }

