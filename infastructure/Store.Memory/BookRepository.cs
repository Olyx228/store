using System;
using System.Linq; 

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
{
                new Book(1, "Art of Programing"),
                new Book(2, "Refactoring"),
                new Book(3, "C Programing Language"),
            };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
