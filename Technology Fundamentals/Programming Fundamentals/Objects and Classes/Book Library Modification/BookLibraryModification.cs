using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Book_Library_Modification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
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
            var endDate = Console.ReadLine();
            var date = DateTime.ParseExact(endDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var sortedBooks = library.Books;
            foreach (var books in library.Books.OrderBy(x => x.Release).ThenBy(x => x.Title))
            {
                if (books.Release > date)
                {
                    Console.WriteLine($"{books.Title} -> {books.Release:d.MM.yyyy}");                    
                }
            }
        }
    }
}
