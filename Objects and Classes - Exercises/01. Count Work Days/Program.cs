using System;
using System.Globalization;

namespace _01.Count_Work_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime startDate = DateTime
                .ParseExact(date, "d-M-yyyy", 
                CultureInfo.InvariantCulture);
            
            date = Console.ReadLine();
            DateTime endDate = DateTime
                .ParseExact(date, "d-M-yyyy",
                CultureInfo.InvariantCulture);

            int totalDays = (int)(endDate - startDate).TotalDays;

            totalDays++;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if ((i.Day == 1 && i.Month == 1) ||
                    (i.Day == 3 && i.Month == 3) ||
                    (i.Day == 1 && i.Month == 5) ||
                    (i.Day == 6 && i.Month == 5) ||
                    (i.Day == 24 && i.Month == 5) ||
                    (i.Day == 6 && i.Month == 9) ||
                    (i.Day == 22 && i.Month == 9) ||
                    (i.Day == 1 && i.Month == 11) ||
                    ((i.Day == 24 || i.Day == 25 ||
                    i.Day == 26) && i.Month == 12) ||
                    (i.DayOfWeek.ToString() == "Saturday") ||
                    (i.DayOfWeek.ToString() == "Sunday"))
                {
                    totalDays--;
                }
            }
            Console.WriteLine(totalDays);
        }
    }
}
