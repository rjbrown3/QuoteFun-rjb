using System;

namespace QuoteFun_rjb
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteTools qt = new QuoteTools();

            string userQuote = "";

            Console.WriteLine("Welcome to the Quote Analyzer!");
            Console.WriteLine("Please enter a quote");

            userQuote = Console.ReadLine();

            Console.WriteLine("Characters: " + qt.CharacterCount(userQuote));
            Console.WriteLine("# Words: " + qt.WordCount(userQuote));
            Console.WriteLine("Count of letters:");
            qt.LetterCount(userQuote);
        }
    }
}
