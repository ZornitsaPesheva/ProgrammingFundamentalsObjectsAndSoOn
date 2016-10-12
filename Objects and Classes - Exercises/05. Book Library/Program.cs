using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            Library library = new Library();
            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                string[] data = Console.ReadLine().
                    Split().ToArray();
                book.Title = data[0];
                book.Author = data[1];
                book.Publisher = data[2];
                book.ReleaseDate = DateTime
                .ParseExact(data[3], "d.M.yyyy",
                CultureInfo.InvariantCulture);
                book.Isbn = data[4];
                book.Price = double.Parse(data[5]);
                books.Add(book);
                library.Name = "Library";
                library.ListOfBooks = books;
                 
            }
            var result = books;
                //.Select(b => b.Sum(x => x.Price))
                //.OrderByDescending(b => b)
              //  .GroupBy(b => b.Author);
            foreach (var r in result)
            {
                Console.WriteLine($"{r.Author} -> {r.Price}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }
    }
}
