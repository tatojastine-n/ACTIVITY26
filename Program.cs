using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Error: Empty input");
                return;
            }
            int maxLength = 0;
            int currentWordLength = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    currentWordLength++;
                }
                else
                {
                    if (currentWordLength > maxLength)
                    {
                        maxLength = currentWordLength;
                    }
                    currentWordLength = 0;
                }
            }
            // Check the last word in case sentence doesn't end with space
            if (currentWordLength > maxLength)
            {
                maxLength = currentWordLength;
            }
            Console.WriteLine($"Length of the longest word: {maxLength}");
        }
    }
}
