using System;
using System.Linq;
using System.Numerics;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            BigInteger sum = SumOfCharacters(input[0], input[1]);
            Console.WriteLine(sum);
        }

        private static BigInteger SumOfCharacters(string v1, string v2)
        {
            BigInteger sum = new BigInteger();
            int minLength = Math.Min(v1.Length, v2.Length);
            for (int i = 0; i < minLength; i++)
            {

                int toAdd = v1[i] * v2[i];
                sum += toAdd;
            }
            if (v1.Length > v2.Length)
            {
                for (int i = minLength; i < v1.Length; i++)
                {
                    sum += v1[i];
                }
            }
            else if (v2.Length > v1.Length)
            {
                for (int i = minLength; i < v2.Length; i++)
                {
                    sum += v2[i];
                }
            }
            return sum;
        }
    }
}
