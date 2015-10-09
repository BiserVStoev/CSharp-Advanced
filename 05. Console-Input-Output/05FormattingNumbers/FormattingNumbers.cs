using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine(@"Enter number ""a"": (0<=a<=500)");
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }
        Console.WriteLine(@"Enter number ""b"":");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine(@"Enter number ""c"":");
        float c = float.Parse(Console.ReadLine());
        Console.Write("|{0,-10}", Convert.ToString(a, 16).ToUpper());
        Console.Write("|{0,10}|", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("{0,10:0.##|}", b);
        Console.Write("{0,-10:0.###}|", c);
        Console.WriteLine();
    }
}
