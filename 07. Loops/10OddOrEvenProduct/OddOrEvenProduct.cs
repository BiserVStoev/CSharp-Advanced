using System;

class OddOrEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integers with a space between them:");
        string[] num = Console.ReadLine().Split();
        int sumOdd = 1;
        int sumEven = 1;
        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd *= Convert.ToInt32(num[i]);
            }
            else
            {
                sumEven *= Convert.ToInt32(num[i]);
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0}", sumOdd);
            Console.WriteLine("even_product = {0}", sumEven);
        }
    }
}
