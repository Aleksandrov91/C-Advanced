using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Book_Library
{
    public class BookLibrary
    {
        public static void Main()
        {
            //var authors = new Dictionary<string, double>();
            var n = int.Parse(Console.ReadLine());
            var library = new Library
            {
                Name = "Book",
                Books = new List<Book>()
            };

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                var currentBook = new Book
                {
                    Title = line[0],
                    Author = line[1],
                    Publisher = line[2],
                    Release = DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNNumber = int.Parse(line[4]),
                    Price = double.Parse(line[5])
                };
                library.Books.Add(currentBook);
            }

            var booksByAuthor = new Dictionary<string, List<Book>>();

            foreach (var book in library.Books)
            {
                if (!booksByAuthor.ContainsKey(book.Author))
                {
                    booksByAuthor[book.Author] = new List<Book>();
                }
                booksByAuthor[book.Author].Add(book);
            }

            foreach (var author in booksByAuthor.OrderByDescending(a => a.Value.Select(x => x.Price).Sum()).ThenBy(x =>x.Key))
            {
                var totalMoney = author.Value.Select(x => x.Price).Sum();
                Console.WriteLine($"{author.Key} -> {totalMoney:F2}");
            }
            //foreach (var book in library.Books)
            //{
            //    if (!authors.ContainsKey(book.Author))
            //    {
            //        authors[book.Author] = book.Price;
            //    }
            //    else
            //    {
            //        authors[book.Author] += book.Price;
            //    }
            //}

            //foreach (var author in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            //{
            //    Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            //}
        }
    }
}
