namespace ExtensionsMethods
{
    //1.Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
    //new StringBuilder and has the same functionality as Substring in the class String.

    using System;
    using System.Text;

    public static class ImplementSubstring
    {
        public static StringBuilder SubString (this StringBuilder input, int index, int length)
        {
            StringBuilder newString = new StringBuilder();
            if (index+length-1 >= input.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range!!!");
            }
            for (int i = index; i < index+length; i++)
            {
                newString.Append(input[i]);
            }

            return newString;
        }
        
        static void Main()
        {
            StringBuilder TestSubstring = new StringBuilder();
            TestSubstring.Append
("Implement an extension method Substringfor the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.");
            Console.WriteLine("This is example: ");
            Console.WriteLine(TestSubstring);
            Console.WriteLine("This is result: ");
            Console.WriteLine(SubString(TestSubstring, 10, 20)); // try with another ints in method
        }
    }
}
