using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n (1<=n<=20): ");
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        if (n >= 1 && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < 2 * n; j++) 
                {
                    if (number < n)
                    {
                        Console.Write("{0} ", j);
                        number++;
                    }
                }
                number = 0;
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input! ");
        }
    }
}
