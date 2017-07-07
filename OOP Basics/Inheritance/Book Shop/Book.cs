namespace Book_Shop
{
    using System;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        protected decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        private string Author
        {
            set
            {
                var names = value.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (names.Length >= 2)
                {
                    if (char.IsDigit(names[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }

                if (names.Length == 3)
                {
                    if (char.IsDigit(names[2][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }

                this.author = value;
            }
        }

        private string Title
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        private decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.title)
                .Append("Author: ").AppendLine(this.author)
                .Append("Price: ").Append($"{this.price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}
