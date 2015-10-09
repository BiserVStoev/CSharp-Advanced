using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter any number from 0 to 999:");
        int n = int.Parse(Console.ReadLine());
        if (n <= 999 && n >= 0)
        {
            switch (n / 100)
            {
                case 0: break;
                case 1: Console.Write("One hundred");
                    break;
                case 2: Console.Write("Two hundred");
                    break;
                case 3: Console.Write("Three hundred ");
                    break;
                case 4: Console.Write("Four hundred ");
                    break;
                case 5: Console.Write("Five hundred ");
                    break;
                case 6: Console.Write("Six hundred ");
                    break;
                case 7: Console.Write("Seven hundred ");
                    break;
                case 8: Console.Write("Eight hundred ");
                    break;
                case 9: Console.Write("Nine hundred ");
                    break;
                default:
                    break;
            }
            if (n % 100 != 0 && n / 100 != 0)
            {
                Console.Write("and ");
            }

            switch (n / 10 % 10)
            {
                case 0: break;
                case 1:
                    switch (n % 10)
                    {
                        case 0: Console.Write("Ten "); break;
                        case 1: Console.Write("Eleven "); break;
                        case 2: Console.Write("Twelve "); break;
                        case 3: Console.Write("Thirteen "); break;
                        case 4: Console.Write("Fourteen "); break;
                        case 5: Console.Write("Fiveteen "); break;
                        case 6: Console.Write("Sixteen "); break;
                        case 7: Console.Write("Seventeen "); break;
                        case 8: Console.Write("Eighteen "); break;
                        case 9: Console.Write("Nineteen "); break;
                        default: break;
                    } break;
                case 2: Console.Write("Twenty "); break;
                case 3: Console.Write("Thirty "); break;
                case 4: Console.Write("Forty "); break;
                case 5: Console.Write("Fifty "); break;
                case 6: Console.Write("Sixty "); break;
                case 7: Console.Write("Seventy "); break;
                case 8: Console.Write("Eighty "); break;
                case 9: Console.Write("Ninety "); break;
                default: break;
            }
            switch (n % 10)
            {
                case 0: if (n == 0) { Console.WriteLine("Zero"); } Console.Write("\n "); break;
                case 1: if (n / 10 % 10 == 1) break; Console.WriteLine("One"); break;
                case 2: if (n / 10 % 10 == 1) break; Console.WriteLine("Two"); break;
                case 3: if (n / 10 % 10 == 1) break; Console.WriteLine("Three"); break;
                case 4: if (n / 10 % 10 == 1) break; Console.WriteLine("Four"); break;
                case 5: if (n / 10 % 10 == 1) break; Console.WriteLine("Five"); break;
                case 6: if (n / 10 % 10 == 1) break; Console.WriteLine("Six"); break;
                case 7: if (n / 10 % 10 == 1) break; Console.WriteLine("Seven"); break;
                case 8: if (n / 10 % 10 == 1) break; Console.WriteLine("Eight"); break;
                case 9: if (n / 10 % 10 == 1) break; Console.WriteLine("Nine"); break;
                default: break;
            }
        }
        else
        {
            Console.WriteLine(" Out of range! ");
        }
    }
}