using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class XExpression
{
    static void Main()
    {
        string expression = Console.ReadLine();
        decimal buffer = 0m;
        decimal result = 0m;
        int[] masiv = new int[expression.Length];

        for (int i = 0; i < expression.Length; i++)
        {
            masiv[i] = expression[i]-48;
        }
        result = masiv[0];
        for (int i = 0; i < expression.Length; i++)
        {
            if (masiv[i] == -6)
            {
                if (masiv[i + 1] == -8)
                {
                    buffer = result;
                    result = masiv[i + 2];
                    continue;                  
                }
                else if (masiv[i] == -7)
	            {
                    result += buffer;
	            }
                else
                {                    
                    result = result * masiv[i + 1];
                }
            }
            else if (masiv[i] == -1)
            {
                if (masiv[i + 1] == -8)
                {
                    buffer = result;
                    result = masiv[i + 2];
                    continue;
                }
                else if (masiv[i] == -7)
                {
                    result += buffer;
                }
                else
                {
                    result = result / masiv[i + 1];
                }                
            }
            else if (masiv[i] == -5)
            {
                if (masiv[i + 1] == -8)
                {
                    buffer = result;
                    result = masiv[i + 2];
                    continue;
                }
                else if (masiv[i] == -7)
                {
                    result += buffer;
                }
                else
                {
                    result = result + masiv[i + 1];
                }                
            }
            else if (masiv[i] == -3)
            {
                if (masiv[i + 1] == -8)
                {
                    buffer = result;
                    result = masiv[i + 2];
                    continue;
                }
                else if (masiv[i] == -7)
                {
                    result += buffer;
                }
                else
                {
                    result = result - masiv[i + 1];
                }       
                
            }
            else if (masiv[i] == -8)
            {
                continue;
            }
            else if (masiv[i] == -7)
            {
                result += buffer;
                continue;
            }
            else if (masiv[i] == 13)
            {
                break;
            }            
            
        }
        
        //print masiv
        //for (int j = 0; j < masiv.Length; j++) 
        //{
        //    Console.WriteLine(masiv[j]);
        //}
        
        Console.WriteLine("{0:F2}", result);
       
    }
}