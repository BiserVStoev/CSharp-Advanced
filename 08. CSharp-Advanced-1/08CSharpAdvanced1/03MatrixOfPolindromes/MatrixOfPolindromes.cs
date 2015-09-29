using System;

class MatrixOfPolindromes
{
    static void Main()
    {
        Console.WriteLine("Enter r:");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c:");
        int c = int.Parse(Console.ReadLine());
        string[,] matrix = new string[r, c];
        char firstLetter = 'a';
        for (char i = 'a'; i < firstLetter + r; i++)
        {
            for (char j = i; j < i + c; j++)
            {
                string letters = i.ToString() + j.ToString() + i.ToString();
                Console.Write("{0} ", letters);       
            }
            Console.WriteLine();
        }
    }
}
