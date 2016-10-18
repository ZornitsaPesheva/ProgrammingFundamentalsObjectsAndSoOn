using System;
using System.Linq;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitChars = new char[] { ',', ' ' };
            string[] banWords = Console.ReadLine()
                .Split(splitChars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*',
                        banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
