using System;
using System.Collections.Generic;
using System.Text;

class EncodeAndDecrypt
{
    static void Main()
    {
    // read input
        string message = Console.ReadLine().TrimEnd();
        string code = Console.ReadLine().TrimEnd();
    // solution
        int codeLength = code.Length;
        int mesLength = message.Length;
        StringBuilder encryptedMessage = new StringBuilder();
        StringBuilder encodedCode = new StringBuilder();
    // encrypted message
        int counter = 0;
        if (message.Length > code.Length)
        {
            string result = EncryptWhenMessageIsLonger(message, code);
            for (int i = 0; i < result.Length; i++)
            {
                encryptedMessage.Append(result[i]);
            }
            // my first solution have 60/100 points
            //for (int i = 0; i < codeLength; i++)
            //{
            //    encryptedMessage.Append(getCode(message[i], code[i]));
            //}
            //int leastLetter = mesLength - codeLength;
            //while (mesLength >= codeLength)
            //{
            //    for (int i = codeLength; i < (codeLength + code.Length); i++)
            //    {
            //        for (int j = counter; j < (counter + 1); j++)
            //        {
            //            if (j < leastLetter)
            //            {
            //                encryptedMessage.Append(getCode(message[i], code[j])); 
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //        counter++;                    
            //    }              
            //    codeLength += code.Length;
            //    counter = 0;
            //}
            //codeLength = code.Length;
        }        
        else if (code.Length > message.Length)
        {
            counter = 0;
            for (int i = 0; i < mesLength; i++)
            {
                encryptedMessage.Append(getCode(message[i], code[i]));
            }
            for (int i = mesLength; i < (codeLength - mesLength) + mesLength; i++)
            {
                for (int j = counter; j < (counter + 1); j++)
                {
                   encryptedMessage.Replace(encryptedMessage[j], getCode(encryptedMessage[j], code[i]), j , 1);
                }
                counter++;
            }
        }
        else
        {
            for (int i = 0; i < message.Length; i++)
            {
                encryptedMessage.Append(getCode(message[i], code[i]));
            }
        }
    // concatened message and code
        for (int i = 0; i < code.Length; i++)
        {
            encryptedMessage.Append(code[i]);
        }

    // encode message        
        string encoded = Encode(encryptedMessage);

    //result
        Console.WriteLine("{0}{1}", encoded, code.Length);
    }

    // run length method
    public static string Encode(StringBuilder source)
    {
        StringBuilder encodedMessage = new StringBuilder();
        for (int i = 0; i < source.Length; i++)
        {
            int runLength = 1;
            while (i + 1 < source.Length && source[i] == source[i + 1])
            {
                runLength++;
                i++;
            }
            if (runLength > 1&&runLength <= 2)
            {
                encodedMessage.Append(source[i]);
            }
            else if (runLength > 2)
            {
                encodedMessage.Append(runLength);                
            }
            encodedMessage.Append(source[i]);
        }
        return encodedMessage.ToString();
    }    

    static char getCode(char message, char code)
    {       
        int mesLet = message - 'A';
        int codeLet = code - 'A';
        char encryptedLetter = (char)((mesLet ^ codeLet) + 'A');
        return encryptedLetter;
    }

    static string EncryptWhenMessageIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder();

        int cypherIndex = 0;

        for (int i = 0; i < message.Length; i++)
        {
            char messageSymbol = message[i];
            char cypherSymbol = cypher[cypherIndex];
            char encrypted = getCode(messageSymbol, cypherSymbol);
            result.Append(encrypted);

            if (cypherIndex == cypher.Length-1)
            {
                cypherIndex = 0;
            }
            else
            {
                cypherIndex++;
            }            
        }
        return result.ToString();
    }
}

