using System;
using System.Linq;
using System.Numerics;

namespace _02.ConvertFromBaseNtoBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine()
                .Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseN = input[0];
            BigInteger number = input[1];
            BigInteger result = ConvertToBase10(number, baseN);
            Console.WriteLine(result);
        }

        private static BigInteger ConvertToBase10(BigInteger n, BigInteger b)
        {
            BigInteger rem;
            BigInteger sum = 0;
            int p = 0;
            while (n > 0)
            {
                rem = n % 10;
                BigInteger bOnPower = BigInteger.Pow((BigInteger)b, p);
                sum = sum + rem * bOnPower;
                n = n / 10;
                p++;
            }
            return sum;
        }
    }
}