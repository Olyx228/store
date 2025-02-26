using System;
using System.Linq; 

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
{
                new Book(1, "ISBN 0201038013", "D. Knuth","Art of Programing, Vol. 1", "Pidarasnoe opisanie", 7.49m),
                new Book(2, "ISBN 0201485672", "M. Fowler", "Refactoring", "Pidarasnoe opisanie 2", 12.45m),
                new Book(3, "ISBN 0131101633", "B. Kernighan, D. Ritchie ", "C Programing Language", "Pidarasnoe opisanie 3", 14.89m),
            };

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query) || book.Title.Contains(query)).ToArray();
        }
    }
}
