using System;
using System.Text;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder num1 = new StringBuilder();
            StringBuilder num2 = new StringBuilder();

            num1 = num1.Append(Console.ReadLine().TrimStart(new char[] { '0' }));
            num2 = num2.Append(Console.ReadLine().TrimStart(new char[] { '0' }));
            StringBuilder sum = Sum(num1, num2);
            Console.WriteLine(sum.ToString());
        }

        private static StringBuilder Sum(StringBuilder num1, StringBuilder num2)
        {
            StringBuilder longerNumber =
                (num1.Length >= num2.Length ? num1 : num2);
            StringBuilder shorterNumber =
                (num1.Length < num2.Length ? num1 : num2);
            StringBuilder sumNum1Num2 = new StringBuilder();
            int j = shorterNumber.Length - 1;
            int ednoNaum = 0;
            if (num2.Length > num1.Length)
            {
                StringBuilder temp = num1;
                num1 = num2;
                num2 = temp;
            }
            for (int i = longerNumber.Length - 1; i >= 0; i--)
            {
                int ednoNaumOld = ednoNaum;
                int toAdd = ((j >= 0) ? int.Parse(num2[j].ToString()) : 0);
                int sum = int.Parse(num1[i].ToString())
                    + toAdd + ednoNaum;
                
                if (sum >= 10)
                {
                    sumNum1Num2.Insert(0, sum % 10);
                    ednoNaum = sum / 10;
                }
                else
                {
                    sumNum1Num2.Insert(0, sum);
                    ednoNaum = 0;
                }
                j--;
            }
            if (ednoNaum > 0)
            {
                sumNum1Num2.Insert(0, ednoNaum);
            }
            return sumNum1Num2;
        }
    }
}
