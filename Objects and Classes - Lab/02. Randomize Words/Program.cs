using System;
using System.Linq;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int tempI = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[tempI];
                words[tempI] = temp;
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
