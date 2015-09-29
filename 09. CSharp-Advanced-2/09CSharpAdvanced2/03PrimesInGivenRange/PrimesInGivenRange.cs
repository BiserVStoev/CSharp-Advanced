using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter start number:");
        int startNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number:");
        int endNumber = int.Parse(Console.ReadLine());
        List<int> primes = FindPrimesInRange(startNumber, endNumber);
        Console.WriteLine(string.Join(", ", primes));
        if (startNumber > endNumber)
        {
            Console.WriteLine("(empty list)");
        }
    }
    static List<int> FindPrimesInRange(int startNumber, int endNumber)
    {
        List<int> primes = new List<int>();
        for (int number = startNumber; number <= endNumber; number++)
			{
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

        return primes;
    }

    static bool IsPrime(int number)
    {
        if (number == 0 || number == 1)
        {
            return false;
        }
        else if (number == 2)
        {
            return true;
        }

        for (int i = 2; i <= Math.Floor(Math.Sqrt(number)); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


