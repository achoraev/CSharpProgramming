using System;

class BonusSwitch
{
    static void Main()
    {
        Console.WriteLine("Enter Number between 1 and 9: ");
        int num;
        int.TryParse(Console.ReadLine(), out num);
        switch (num)
        {
            case 1:
            case 2:
            case 3: num *= 10; Console.WriteLine("The bonus score is {0}", num); break;
            case 4:
            case 5:
            case 6: num *= 100; Console.WriteLine("The bonus score is {0}", num); break;
            case 7:
            case 8:
            case 9: num *= 1000; Console.WriteLine("The bonus score is {0}", num); break;
            default: Console.WriteLine("Enter Number between 1 and 9: "); break;

        }

    }
}
