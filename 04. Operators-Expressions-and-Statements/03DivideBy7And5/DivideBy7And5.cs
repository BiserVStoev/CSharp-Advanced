using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Write an integer: ");
        int n = int.Parse(Console.ReadLine());
        bool check = n % 7 == 0 && n % 5 == 0;
        Console.WriteLine(check);
    }
}
