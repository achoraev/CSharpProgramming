using System;
using System.Numerics;

    class Secret
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());            
            BigInteger specialSum = 0;
            BigInteger digit = 0;            
            if (number < 0)
            {
                number *= (-1);
            }
            BigInteger currentNumber = number;
            for (int i = 1; i < 100000; i++)
            {                
                if (i % 2 == 0)
                {
                    digit = (currentNumber % 10); 
                    specialSum += (digit * digit) * i;                    
                }
                else if (i % 2 != 0)
                {
                    digit = (currentNumber % 10); 
                    specialSum += digit * (i * i);                    
                }
                currentNumber = currentNumber / 10;
                if (currentNumber == 0)
                {
                    break;
                }
                }
                int countSequence = (int)specialSum % 10;
                if (countSequence == 0)
                {
                    Console.WriteLine(specialSum);
                    Console.WriteLine("{0} has no secret alpha-sequence", number);
                }
                else
                {
                int startNum = (((int)specialSum % 26) + 1);
                startNum += 64;                
                Console.WriteLine(specialSum);                
                for (int i = 0; i < countSequence; i++)
                {                    
                    Console.Write((char)startNum);
                    startNum += 1;
                    if (startNum > 'Z')
                    {
                        startNum = (startNum - 'Z' + 'A' -1);
                    }
                }
                Console.WriteLine();
            }
        }
    }

