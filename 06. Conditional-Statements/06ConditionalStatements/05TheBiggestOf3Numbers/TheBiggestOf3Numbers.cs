﻿using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numberas:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a > c)
        {
            Console.WriteLine("biggest: {0}", a);
        }
        else if (b >= c && b > a)
        {
            Console.WriteLine("biggest: {0}", b);
        }
        else if (c >= a && a > b || c > a && a == b)
        {
            Console.WriteLine("biggest: {0}", c);
        }
    }
}