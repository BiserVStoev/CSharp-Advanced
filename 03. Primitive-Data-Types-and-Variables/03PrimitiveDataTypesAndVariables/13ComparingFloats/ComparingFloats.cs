using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first floating-point number:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second floating-point number:");
        float b = float.Parse(Console.ReadLine());
        bool areEqual = a==b;
        Console.WriteLine(areEqual);
    }
}
