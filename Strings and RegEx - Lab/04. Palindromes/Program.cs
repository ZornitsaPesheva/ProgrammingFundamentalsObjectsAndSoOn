using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' ', '!', '?', '.', ','}, 
                StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (string word in words.Distinct()
                .OrderBy(w => w))
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static bool IsPalindrome(string word)
        {
            bool result = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
