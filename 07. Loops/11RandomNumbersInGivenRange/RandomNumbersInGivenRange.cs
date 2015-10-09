using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max:");
        int max = int.Parse(Console.ReadLine());
        if (min >= max)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else
        {
            Random rnd = new Random();
            for (int i = 0; i <= n; i++)
            {
                int random = rnd.Next(min, max + 1);
                Console.WriteLine(random);
            }
        }
    }
}
