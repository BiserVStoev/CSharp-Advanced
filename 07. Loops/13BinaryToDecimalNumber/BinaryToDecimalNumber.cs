using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Input binary integer:");
        string bInt = Console.ReadLine();
        int[] num = new int[bInt.Length];
        long decimalNum = 0;
        long degree = bInt.Length - 1;
        for (int i = 0; i < bInt.Length; i++)
		{
            num[i]= (int)(bInt[i]) - '0';
            decimalNum+=num[i]*(long)Math.Pow(2,degree);
            degree--;
		}
        Console.WriteLine("{0}",decimalNum);
    }
}
