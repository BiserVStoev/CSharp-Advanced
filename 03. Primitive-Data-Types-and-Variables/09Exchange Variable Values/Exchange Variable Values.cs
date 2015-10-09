using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}