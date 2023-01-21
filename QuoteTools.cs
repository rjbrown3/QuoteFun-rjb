using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteFun_rjb
{
    public class QuoteTools
    {
        //count # words 

        public int WordCount(string quote)
        {
            string[] words = quote.Split(' ');
            int numWords = 0;

            numWords = words.Length;

            return numWords;
        }

        //Count # characters 
        public int CharacterCount(string quote)
        {
            int numCharacters = 0;
            numCharacters = quote.Length;

            return numCharacters;
        }

        //Letter count 
        public void LetterCount(string quote)
        {
            char ch = ' ';
            int[] letters = new int[26];

            //count the letters
            for (int i = 0; i < quote.Length; i++)
            {
                ch = quote[i];
                ch = Char.ToUpper(ch);

                //check to see if the character is a letter
                if (ch >= 'A' && ch <= 'Z')
                {
                    letters[(ch - 65)]++;
                }
            }
            
            //print results
            for (int i = 0; i < letters.Length; i++)
            {
                char letterSymbol = ' ';

                letterSymbol = (char) (i + 65);

                Console.WriteLine(letterSymbol + ": " + letters[i]);
            }
        }
    }
}
