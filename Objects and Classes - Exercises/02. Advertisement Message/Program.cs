using System;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int number = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 1; i <= number; i++)
            {
                int n = 0;
                n = rnd.Next(phrases.Length);
                string phrase = phrases[n];
                n = rnd.Next(events.Length);
                string eventx = events[n];
                n = rnd.Next(authors.Length);
                string author = authors[n];
                n = rnd.Next(cities.Length);
                string city = cities[n];
                Console.WriteLine($"{phrase} {eventx} {author} - {city}");
            }

        }
    }
}
