using System;

namespace Book_Library
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime Release { get; set; }

        public int ISBNNumber { get; set; }

        public double Price { get; set; }
    }
}
