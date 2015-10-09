using System;

class NumbersInIntervalDividebleByN
{
static void Main()
{
        Console.WriteLine("Enter two positive integer's:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int p = 0;
        if (a >= 0 && b >= 0)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine(p);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
