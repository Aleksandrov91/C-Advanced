namespace _02.Book_Shop
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;
        private Regex rgx = new Regex(@"^\d+");

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            private set
            {
                var validateAuthor = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (validateAuthor.Length > 1 && this.rgx.IsMatch(validateAuthor[1]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Type: ");
            sb.AppendLine($"{this.GetType().Name}");
            sb.Append($"Title: ");
            sb.AppendLine($"{this.Title}");
            sb.Append($"Author: ");
            sb.AppendLine($"{this.Author}");
            sb.Append($"Price: ");
            sb.AppendLine($"{this.Price:F1}");

            return sb.ToString();
        }
    }
}
