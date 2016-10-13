using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt")
                .ToLower().Split();
            string[] text = File.ReadAllText("input.txt")
                .ToLower().Split(new char[] 
                {'\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount =
                new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            foreach (var word in wordCount.OrderByDescending(
                p => p.Value))
            {
                  File.AppendAllText("output.txt", 
                      $"{word.Key} - {word.Value}{Environment.NewLine}");
            }
        }
    }
}
