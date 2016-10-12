using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dateTime = DateTime
                .ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
