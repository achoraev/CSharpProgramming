namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Test
    {
        static void Main()
        {
            Generic<int> test = new Generic<int>();
            //test add with int         
            for (int i = 0; i < 20; i++)
            {
                test.AddElement(i+1); 
            }
            Console.WriteLine(test);
            //test find element
            Console.WriteLine("Element is in {0} position.", test.FindElement(15));
            //test remove element
            test.RemoveElement(14);
            Console.WriteLine(test);
            //test min / max
            Console.WriteLine("Minimal element is: {0} ", GenericMinMaxMethods.Min(test));
            Console.WriteLine("Maximal element is: {0} ", GenericMinMaxMethods.Max(test));
            //test clear
            test.ClearList();
            Console.WriteLine(test);
            
            //test with strings
            Generic<string> testString = new Generic<string>();
            testString.AddElement("Java");
            testString.AddElement("C#");
            testString.AddElement("JavaScript");
            Console.WriteLine(testString);
            Console.WriteLine("Element is in {0} position.", testString.FindElement("C#"));
            // test indexer
            Console.WriteLine("Element in position 2 is: " + testString[2]);
            //test insert
            testString.InsertElement(1, "PHP");
            Console.WriteLine(testString);
            //test min / max
            Console.WriteLine("Minimal element is: {0} ", GenericMinMaxMethods.Min(testString));
            Console.WriteLine("Maximal element is: {0} ", GenericMinMaxMethods.Max(testString));
        }
    }
}
