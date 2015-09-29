using System;

    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            string d = (string)c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }

