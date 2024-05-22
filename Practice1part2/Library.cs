using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1part2
{
    class Library
    {
        private Dictionary<string, List<Book>> booksByGenre;

        public Library()
        {
            booksByGenre = new Dictionary<string, List<Book>>();
        }

        public void AddBook(string genre, Book book)
        {
            if (!booksByGenre.ContainsKey(genre))
            {
                booksByGenre[genre] = new List<Book>();
                Console.WriteLine($"Added new genre '{genre}'.");
            }
            booksByGenre[genre].Add(book);
            Console.WriteLine($"Book '{book.Title}' successfully added in genre '{genre}'.\n");
        }

        public void RemoveBook(string genre, string title)
        {
            if (!booksByGenre.ContainsKey(genre))
            {
                Console.WriteLine($"Genre '{genre}' not found.\n");
                return;
            }

            var bookToRemove = booksByGenre[genre].FirstOrDefault(b => b.Title == title);
            if (bookToRemove == null)
            {
                Console.WriteLine($"Book '{title}' not found in genre '{genre}'.\n");
                return;
            }

            booksByGenre[genre].Remove(bookToRemove);
            Console.WriteLine($"Book '{title}' successfully removed.\n");
        }

        public void ListBooksInGenre(string genre)
        {
            if (!booksByGenre.ContainsKey(genre))
            {
                Console.WriteLine($"Genre '{genre}' not found.\n");
                return;
            }

            Console.WriteLine($"Books in genre '{genre}':");
            foreach (var book in booksByGenre[genre])
            {
                Console.WriteLine($"  {book}");
            }

            Console.WriteLine();
        }

        public void ListAllBooks()
        {
            Console.WriteLine("All books in the library:");
            foreach (var genre in booksByGenre.Keys)
            {
                Console.WriteLine($"Genre: {genre}");
                foreach (var book in booksByGenre[genre])
                {
                    Console.WriteLine($"  {book}");
                }
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook("Fantasy", new Book("The Hobbit", "J.R.R. Tolkien"));
            library.AddBook("Fantasy", new Book("The Fellowship of the Ring", "J.R.R. Tolkien"));
            library.AddBook("Dystopian", new Book("1984", "George Orwell"));
            library.AddBook("Classic", new Book("To Kill a Mockingbird", "Harper Lee"));

            library.ListBooksInGenre("Fantasy");

            library.RemoveBook("Fantasy", "The Hobbit");

            library.ListBooksInGenre("Fantasy");

            library.ListAllBooks();
        }
    }
}
