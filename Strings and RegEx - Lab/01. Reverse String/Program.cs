using System;
using System.Linq;


namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverced = string.Join("", input.Reverse());
            // string reversed = Reverse(input);
            Console.WriteLine(reverced);
        }

        //public static string Reverse(string s)
        //{
        //    char[] charArray = s.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}
    }
}
