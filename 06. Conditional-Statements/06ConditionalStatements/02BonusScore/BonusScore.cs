﻿using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter bonus score:");
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 3)
        {
            Console.WriteLine("result: {0}", score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.WriteLine("result: {0}", score * 100);
        }
        else if (score >= 7 && score <= 9)
        {
            Console.WriteLine("result: {0}", score * 1000);
        }
        else if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

