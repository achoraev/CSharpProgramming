using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class TwoGirlsOnePath
{
    public static void Main()
    {
        // READ INPUT
        string[] input = Console.ReadLine().TrimEnd().Split();
        BigInteger[] fullPath = new BigInteger[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            fullPath[i] = BigInteger.Parse(input[i]);
        }

        // solution
        bool mollyVisitZero = false;
        bool dollyVisitZero = false;
        int len = fullPath.Length;
        BigInteger mollyResult = fullPath[0];
        BigInteger dollyResult = fullPath[len - 1];
        BigInteger mollyCurrentPosition = fullPath[0];
        fullPath[0] = 0;
        BigInteger dollyCurrentPosition = len - fullPath[len - 1] - 1;
        fullPath[len - 1] = 0;
        BigInteger oldPositionMolly = 0;
        BigInteger oldPositionDolly = len - 1;

        while (true)
        {
            // girls moves
            if (mollyCurrentPosition >= len)
            {
                mollyCurrentPosition %= len;
            }

            if (dollyCurrentPosition < 0)
            {
                dollyCurrentPosition = len + (dollyCurrentPosition % len);
                if (dollyCurrentPosition == len)
                {
                    dollyCurrentPosition = 0;
                }
            }

            if (fullPath[(long)mollyCurrentPosition] == 0)
            {
                mollyVisitZero = true;
            }

            if (fullPath[(long)dollyCurrentPosition] == 0)
            {
                dollyVisitZero = true;
            }

            if (mollyCurrentPosition == dollyCurrentPosition)
            {
                mollyResult += mollyCurrentPosition / 2;
                dollyResult += dollyCurrentPosition / 2;
                oldPositionMolly = mollyCurrentPosition;
                oldPositionDolly = dollyCurrentPosition;
                mollyCurrentPosition += fullPath[(long)oldPositionMolly];
                dollyCurrentPosition = oldPositionDolly - fullPath[(long)oldPositionDolly];
                if (mollyCurrentPosition % 2 == 0)
                {
                    fullPath[(long)oldPositionMolly] = 0;
                }
                else
                {
                    fullPath[(long)oldPositionMolly] = 1;
                }
            }
            else if (!mollyVisitZero && !dollyVisitZero)
            {
                mollyResult += fullPath[(long)mollyCurrentPosition];
                dollyResult += fullPath[(long)dollyCurrentPosition];
                oldPositionMolly = mollyCurrentPosition;
                oldPositionDolly = dollyCurrentPosition;
                mollyCurrentPosition += fullPath[(long)oldPositionMolly];
                dollyCurrentPosition = oldPositionDolly - fullPath[(long)oldPositionDolly];
                fullPath[(long)oldPositionMolly] = 0;
                fullPath[(long)oldPositionDolly] = 0;
            }

            if (mollyVisitZero || dollyVisitZero)
            {
                mollyResult += fullPath[(long)mollyCurrentPosition];
                dollyResult += fullPath[(long)dollyCurrentPosition];
            }

            if (mollyVisitZero || dollyVisitZero)
            {
                break;
            }
        }

        // print result
        if ((mollyVisitZero && dollyVisitZero) || mollyResult == dollyResult)
        {
            Console.WriteLine("Draw");
            Console.Write(mollyResult + " " + dollyResult);
        }
        else if (dollyVisitZero)
        {
            Console.WriteLine("Molly");
            Console.Write(mollyResult + " " + dollyResult);
        }
        else if (mollyVisitZero)
        {
            Console.WriteLine("Dolly");
            Console.Write(mollyResult + " " + dollyResult);
        }

        Console.WriteLine();
    }
}