using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        uint number = uint.Parse(Console.ReadLine());
        uint nRightP = number >> 3;
        uint bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}
