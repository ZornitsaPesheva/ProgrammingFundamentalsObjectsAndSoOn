using System;
using System.Linq;
using System.Text;
using System.Numerics;


namespace _01.ConvertFromBase10toBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine()
                .Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseN = input[0];
            BigInteger number = input[1];
            BigInteger result = ConvertToBaseN(number, baseN);
            Console.WriteLine(result);
        }

        private static BigInteger ConvertToBaseN(BigInteger n, BigInteger b)
        {
            StringBuilder str = new StringBuilder();
            BigInteger reminder;
            while (n > 0)
            {
                reminder = n % b;
                n = n / b;
                str = str.Insert(0, reminder);
            }
            return BigInteger.Parse(str.ToString());
        }
    }
}
