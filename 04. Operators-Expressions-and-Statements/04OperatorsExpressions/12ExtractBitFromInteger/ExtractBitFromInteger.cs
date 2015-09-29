using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index: ");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}
