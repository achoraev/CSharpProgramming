using System;

class FighterAttack
{
    static void Main()
    {
        int PX1 = int.Parse(Console.ReadLine());
        int PY1 = int.Parse(Console.ReadLine());
        int PX2 = int.Parse(Console.ReadLine());
        int PY2 = int.Parse(Console.ReadLine());
        int FX = int.Parse(Console.ReadLine());
        int FY = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int leftX = 0;
        int rightX = 0;
        int topY = 0;
        int bottomY = 0;
        int counter = 0;

        if (D <= 0)
        {
            Console.WriteLine("0%");
        }
        else
        {
            if (PX1 < PX2)
            {
                leftX = PX1;
            }
            else
            {
                rightX = PX1;
            }
            if (PY1 < PY2)
            {
                bottomY = PY1;
            }
            else
            {
                topY = PY1;
            }
            if (bottomY == PY1 && FY > bottomY)
            {
                counter = 100;
                if (FY - 1 > bottomY)
                {
                    counter += 50;
                }
                if ((FY + 1) < bottomY + (PY2 - PY1))
                {
                    counter += 50;
                }
            }
            else if (topY == PY1 && FY < topY)
            {
                counter = 100;
                if (FY - 1 > topY)
                {
                    counter += 50;
                }
                if ((FY + 1) < topY + (PY2 - PY1))
                {
                    counter += 50;
                }
            }
            Console.WriteLine("{0}%", counter);
        }
    }
}