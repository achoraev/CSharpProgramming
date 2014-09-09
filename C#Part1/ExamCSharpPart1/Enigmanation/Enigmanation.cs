using System;

class Enigmanation
{
    static void Main()
    {
        string expression = Console.ReadLine();
        decimal buffer = 0m;
        decimal result = 0m;
        decimal lastDigit = 0m;
        int[] masiv = new int[expression.Length+1];

        for (int i = 0; i < expression.Length; i++)
        {
            masiv[i] = expression[i] - 48;
        }
        if (masiv[0] == -8)
        {
            result = masiv[1];
        }
        else
        {
            result = masiv[0];
        }
        
        for (int i = 0; i < expression.Length; i++)
        {
            if (masiv[i + 1] == -8)
	        {
		        buffer = result;
                result = masiv[i + 2];
                lastDigit = masiv[i];
                continue;
	        }
            else if (masiv[i] == -6)// Umnojenie
            {               
                result = result * masiv[i + 1];                
            }
            else if (masiv[i] == -11) // celochisleno delenie
            {                
                result = result % masiv[i + 1];                
            }
            else if (masiv[i] == -5) // sabirane
            {                
                result = result + masiv[i + 1];                
            }
            else if (masiv[i] == -3) // izvajdane
            {                
                result = result - masiv[i + 1];                
            }
            
            else if (masiv[i] == -7)
            {
                if (lastDigit == -3)
                {
                    result =  buffer - result;
                }
                else if (lastDigit == -5)
                {
                    result += buffer;
                }
                else if (lastDigit == -11)
                {
                    result = result % buffer;
                }
                else if (lastDigit == -6)
                {
                    result *= buffer;
                }
                //if (buffer > result)
                //{
                //    result *= -1;
                //}
            }
            else if (masiv[i] == 13) //ravno
            {
                break;
            }
        }
        Console.WriteLine("{0:F3}", result);
    }
}

