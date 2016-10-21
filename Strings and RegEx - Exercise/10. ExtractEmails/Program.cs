using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] {' '}
                , StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern 
                = @"^([a-zA-Z]+[.]*)([a-zA-Z]*[-]*[a-zA-Z]*)[@][a-zA-Z]+[-]*[a-zA-Z]*[.][a-zA-Z]+([.]*[a-zA-Z])*$";

            foreach (var item in text)
            {

            }

        }
    }
}
