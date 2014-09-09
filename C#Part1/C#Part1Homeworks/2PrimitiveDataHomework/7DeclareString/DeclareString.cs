using System;

    class DeclareString
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            Console.WriteLine(helloWorld);
            string typeCast = (string)helloWorld;
            Console.WriteLine(typeCast);
        }
    }
