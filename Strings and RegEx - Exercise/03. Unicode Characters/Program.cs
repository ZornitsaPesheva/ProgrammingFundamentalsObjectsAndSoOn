using System;
using System.Text;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.AppendFormat("\\u{0:x4}", (int)(input[i]));
            }

            Console.WriteLine(result);
        }
    }
}
