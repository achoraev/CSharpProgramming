using System;
using System.Text;

class GenomeDecoder
{
    static void Main()
    {
        //read input
        string numberNandM = Console.ReadLine();
        string[] numberSplit = numberNandM.Split(' ');
        int numberN = int.Parse(numberSplit[0]);
        int numberM = int.Parse(numberSplit[1]);        
        string encodedGenome = Console.ReadLine();
        string repeatedTime = "";
        string letter = "";
        StringBuilder decodedGenome = new StringBuilder();
        
        for (int i = 0; i < encodedGenome.Length; i++)
        {
            
            if (encodedGenome[i]== 'A' ||
                encodedGenome[i]== 'G' ||
                encodedGenome[i]== 'C' ||
                encodedGenome[i]== 'T')
            {
                letter = encodedGenome[i].ToString();                             
                BuildGenome(repeatedTime, letter, decodedGenome);
                repeatedTime = "";
                letter = "";
            }
            else
            {
                repeatedTime += encodedGenome[i].ToString();
            }            
        }

        // print genome        
        PrintGenome(decodedGenome, numberN, numberM);
    }

    private static void BuildGenome(string repeatedTime, string letter, StringBuilder decodedGenome)
    {
        if (repeatedTime == "")
        {   
            repeatedTime = "1";
        }
        for (int i = 1; i <= int.Parse(repeatedTime); i++)
        {
            decodedGenome.Append(letter);
        }
    }

    private static void PrintGenome(StringBuilder decodedGenome, int numberN, int numberM)
    {
        int count = 0;
        int space = 0;
        int rows = (int)Math.Ceiling((decimal)decodedGenome.Length / numberN);
        int pad = 1;

        if (rows > 99999)
        {
            pad = 6;
        }
        else if (rows > 9999)
        {
            pad = 5;
        }
        else if (rows > 999)
        {
            pad = 4;
        }
        else if (rows > 99)
        {
            pad = 3;
        }
        else if (rows > 9)
        {
            pad = 2;
        }        
        for (int i = 1; i <= rows; i++)
        {            
            Console.Write("{0}", i.ToString().PadLeft(pad));
            //first variant
            StringBuilder currentRow = new StringBuilder();
            for (int j = 0; j < (numberN+space); j++)
            {
                if (j % (numberM + 1) == 0 && j <= (numberN + space))
                {
                    currentRow.Append(" ");
                    space++;
                }
                else
                {
                    currentRow.Append(decodedGenome[count]);
                    if (count < decodedGenome.Length-1)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(currentRow);
            space = 0;
            currentRow.Clear();
            //second variant print slow and over time limit only 50/100 points
            //for (int j = 1; j <= (numberN+space+1); j++)
            //{
            //    if (j % (numberM+1) == 0 && j <= (numberN+space))
            //    {
            //        Console.Write(" ");
            //        space++;
            //    }
            //    else if (j % (numberN+space+1) == 0)
            //    {
            //        Console.WriteLine();
            //        space = 0;
            //        break;
            //    }
            //    else
            //    {
            //        if (count == decodedGenome.Length)
            //        {
            //            Console.WriteLine();
            //            break;
            //        }
            //        else
            //        {
            //            Console.Write("{0}", decodedGenome[count]);
            //            count++;
            //        }                              
            //    }
            //}
        }
    } 
}

