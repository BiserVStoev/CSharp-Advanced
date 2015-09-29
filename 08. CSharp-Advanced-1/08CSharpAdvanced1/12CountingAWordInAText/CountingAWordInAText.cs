using System;
using System.Linq;

namespace _16_CountingWordInText
{
    class CountingWordInText
    {
        static void Main(string[] args)
        {
            string wordToSearch = Console.ReadLine();
            string text = Console.ReadLine();
            foreach (var symbol in text)
            {
                if (!Char.IsLetter(symbol))
                {
                    text = text.Replace(symbol, ' ');
                }
            }
            string[] list = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string wordToSearchToLower = wordToSearch.ToLower();
            int count = list.Count(w => w.ToLower() == wordToSearchToLower);
            Console.WriteLine(count);
        }
    }
}