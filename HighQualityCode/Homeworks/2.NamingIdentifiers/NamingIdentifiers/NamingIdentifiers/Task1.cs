using System;

public class Input
{    
    // not use const anywhere
    // public const int MAXCOUNT = 6;

    public static void Main()
    {
        Input.InsideInput trueOrFalse = new Input.InsideInput();
        trueOrFalse.CheckIsTrue(true);
    }

    public class InsideInput
    {
        public void CheckIsTrue(bool isTrue)
        {
            string variableAsString = isTrue.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}