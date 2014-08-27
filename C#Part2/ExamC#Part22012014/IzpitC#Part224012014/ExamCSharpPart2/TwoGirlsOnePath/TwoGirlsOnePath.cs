using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class TwoGirlsOnePath
{
    static void Main()
    {
        //READ INPUT
        string [] input = Console.ReadLine().TrimEnd().Split();
        BigInteger[] fullPath = new BigInteger[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            fullPath[i] = (BigInteger.Parse(input[i]));
        }
        // solution
        bool mollyVisitZero = false;
        //bool isVisitedFromMolly = false;
        //bool isVisitedFromDolly = false;
        BigInteger MollyResult = 0;
        BigInteger DollyResult = 0;        
        MollyResult += fullPath[0];
        DollyResult += fullPath[fullPath.Length - 1];
        BigInteger mollyNextPos = fullPath[0];
        fullPath[0] = 0;
        BigInteger dollysNextPos = fullPath[fullPath.Length - 1];
        fullPath[fullPath.Length - 1] = 0;
        BigInteger oldPositionMolly = 0;
        BigInteger oldPositionDolly = 0;        
        while (true)
        {                        
            //mollys moves
            if (mollyNextPos > fullPath.Length)
            {
                mollyNextPos = mollyNextPos % fullPath.Length;//???
            }
            if (dollysNextPos > fullPath.Length)
            {
                dollysNextPos = dollysNextPos % fullPath.Length;
            }
            if (fullPath[(long)mollyNextPos] == 0)
            {                
                mollyVisitZero = true;
            }
            if (fullPath[(long)(fullPath.Length - dollysNextPos - 1)] == 0)
            {
                break;
            }
            else
            {
                if (mollyNextPos == dollysNextPos)
                {
                    MollyResult += mollyNextPos/2;
                    DollyResult += mollyNextPos / 2;
                    oldPositionMolly = mollyNextPos;
                    oldPositionDolly = fullPath.Length - dollysNextPos - 1;
                    mollyNextPos += fullPath[(long)mollyNextPos];
                    dollysNextPos += fullPath[(long)oldPositionDolly];
                    if (mollyNextPos % 2 == 0)
                    {
                        fullPath[(long)oldPositionMolly] = 0;
                        fullPath[(long)oldPositionDolly] = 0;  
                    }
                    else
                    {
                        fullPath[(long)oldPositionMolly] = 1;
                        fullPath[(long)oldPositionDolly] = 1;    
                    }
                }
                else
	            {
	                MollyResult += fullPath[(long)mollyNextPos];
                    DollyResult += fullPath[(long)(fullPath.Length - dollysNextPos - 1)]; 	            
                    oldPositionMolly = mollyNextPos;
                    oldPositionDolly = fullPath.Length - dollysNextPos - 1;
                    mollyNextPos += fullPath[(long)mollyNextPos];
                    dollysNextPos += fullPath[(long)oldPositionDolly];
                    fullPath[(long)oldPositionMolly] = 0;
                    fullPath[(long)oldPositionDolly] = 0; 
                }
            }
            if (mollyVisitZero)
            {
                break;
            }                        
        }

        //print result
        if (MollyResult>DollyResult)
        {
            Console.WriteLine("Molly");
            Console.Write(MollyResult);
            Console.Write(" ");
            Console.Write(DollyResult);
        }
        else if (MollyResult<DollyResult)
        {
            Console.WriteLine("Dolly");
            Console.Write(MollyResult);
            Console.Write(" ");
            Console.Write(DollyResult);
        }
        else
        {
            Console.WriteLine("Draw");
            Console.Write(MollyResult);
            Console.Write(" ");
            Console.Write(DollyResult);
        }
        Console.WriteLine();
    }
}

