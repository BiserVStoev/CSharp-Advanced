using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n:");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        int randomNumber = 1;
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            randomNumber = rnd.Next(1, n + 1);
            num[i] = randomNumber;
        }
        foreach (var item in num)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}