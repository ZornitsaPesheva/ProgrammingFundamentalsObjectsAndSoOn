using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            AreTheyExchangebles(input[0], input[1]);
        }

        private static void AreTheyExchangebles(string v1, string v2)
        {
            int len = Math.Min(v1.Length, v2.Length);
            int fistLen = v1.ToCharArray().Distinct().Count();
            int secondLen = v2.ToCharArray().Distinct().Count();

            if (fistLen != secondLen)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 1; i < len; i++)
                {
                    bool check1 = v1[i] == v1[i - 1];
                    bool check2 = v2[i] == v2[i - 1];

                    if (check1 != check2)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }

        }

        //private static bool AreTheyExchangebles(string v1, string v2)
        //{
        //    Dictionary<char, char> dict = new Dictionary<char, char>();
        //    int minLength = Math.Min(v1.Length, v2.Length);
        //    for (int i = 0; i < minLength; i++)
        //    {
        //        if (dict.ContainsKey(v1[i]))
        //        {
        //            if (dict[v1[i]] != v2[i])
        //            {
        //                return false;
        //            } 
        //        }
        //        else
        //        {
        //            dict[v1[i]] = v2[i];
        //        }
        //    }
        //    if (v1.Length > v2.Length)
        //    {
        //        for (int i = minLength; i < v1.Length; i++)
        //        {
        //            if (!dict.ContainsKey(v1[i]))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    else if (v2.Length > v1.Length)
        //    {
        //        for (int i = minLength; i < v2.Length; i++)
        //        {
        //            if (!dict.ContainsValue(v2[i]))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
