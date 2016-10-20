using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            bool exchangeble =
                AreTheyExchangebles(input[0], input[1]);
            if (exchangeble)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        private static bool AreTheyExchangebles(string v1, string v2)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            int minLength = Math.Min(v1.Length, v2.Length);
            for (int i = 0; i < minLength; i++)
            {

                if (dict.ContainsKey(v1[i]))
                {
                    if (dict[v1[i]] != v2[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(v2[i]))
                    {
                        return false;
                    }
                    dict[v1[i]] = v2[i];
                }
            }
            if (v1.Length > v2.Length)
            {
                for (int i = minLength; i < v1.Length; i++)
                {
                    if (!dict.ContainsKey(v1[i]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = minLength; i < v2.Length; i++)
                {
                    if (!dict.ContainsValue(v2[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}