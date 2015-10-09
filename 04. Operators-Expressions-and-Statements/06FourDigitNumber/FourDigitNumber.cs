using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a four digit number: ");
        int number = int.Parse(Console.ReadLine());
        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine(d + "" + c + "" + b + "" + a);
        Console.WriteLine(d + "" + a + "" + b + "" + c);
        Console.WriteLine(a + "" + c + "" + b + "" + d);
    }
}
