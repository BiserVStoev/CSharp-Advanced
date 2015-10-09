using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        try
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (Math.Max(p, q) + k - 1 > 31)
            {
                Console.WriteLine("out of range");
            }
            else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;
                    uint bitQ = (n & (mask << q)) >> q;
                    uint bitP = (n & (mask << p)) >> i;

                    n &= ~(mask << i); //nullify
                    n |= bitP << q;//change bit q
                    n &= ~(mask << q);//nullify
                    n |= bitQ << i;//change bit p
                    q++;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("out of range");
        }
    }
}
