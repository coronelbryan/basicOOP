using System.Collections.Generic;
using static System.Console;

namespace Exercise1
{
    public class Library
    {
        private readonly string name;
        private IList<Book> books;

        public Library(
            string name,
            List<Book> books)
        {
            this.name = name;
            this.books = books;
        }

        public void AddBook(Book book) => this.books.Add(book);        

        public void BorrowBook(string title)
        {
            var bookToBorrow = FindBook(title);
            if (bookToBorrow is null)
            {
                WriteLine("Book title does not exists");
                return;
            }

            if (!bookToBorrow.IsAvailable)
            {
                WriteLine("Book is not available");
            }

            bookToBorrow.Borrow();
            WriteLine($"Book {bookToBorrow.Title} has been borrowed!");
        }

        public void ReturnBook(string title)
        {
            var bookToReturn = FindBook(title);
            if (bookToReturn is null)
            {
                WriteLine("Book title does not exists");
                return;
            }

            // this is optional
            if (bookToReturn.IsAvailable)
            {
                WriteLine($"Book {bookToReturn.Title} has not been borrowed!");
            }

            bookToReturn.Return();
            WriteLine($"Book {bookToReturn.Title} has been returned");
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
               WriteLine(book.ToString());
            }
        }

        public Book FindBook(string title)
        {
            foreach (var book in this.books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }

            return null;
        }
    }
}