using System.Linq;
using static System.Console;

namespace Exercise1
{
    public class Book
    {
        private readonly string title;
        private readonly string author;
        private readonly int publication;
        private bool isAvailable;

        public Book(
            string title,
            string author,
            int yearPublication)
        {
            this.title = title;
            this.author = author;
            this.publication = yearPublication;
            this.isAvailable = true;
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
        }

        public void Borrow() => this.isAvailable = false;

        public void Return() => this.isAvailable = true;

        public override string ToString() => $"{this.title}, {this.author}, {this.publication}, {(this.isAvailable ? "Available" : "Borrowed")} ";
    }
}